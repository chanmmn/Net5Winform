using QRCoder;

namespace WinFormQR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap GenerateQRCode(string text)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var text = txtTextToEncode.Text;
            var qrCodeImage = GenerateQRCode(text);
            pictureBox1.Image = qrCodeImage;
        }


    }
}