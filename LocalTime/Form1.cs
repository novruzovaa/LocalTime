namespace LocalTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Baku_Click(object sender, EventArgs e)
        {
            DateTime thisTime = DateTime.Now;
            TimeZoneInfo tst = TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time");
            DateTime tstTime = TimeZoneInfo.ConvertTime(thisTime, TimeZoneInfo.Local, tst);
            lbl_baku.Text = tstTime.ToString();
            lbl_baku.Visible = true;
            btn_London.Visible = false;
            

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            btn_London.Visible = true;
            btn_Baku.Visible = true;
            lbl_london.Visible = false;
            lbl_baku.Visible = false;
            this.BackgroundImage = Properties.Resources.baku;

        }

        private void btn_London_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.london;
            btn_Baku.Visible = false;
           
            DateTime thisTime = DateTime.Now;
            TimeZoneInfo tst = TimeZoneInfo.FindSystemTimeZoneById("Greenwich Standard Time");
            DateTime tstTime = TimeZoneInfo.ConvertTime(thisTime, TimeZoneInfo.Local, tst);
            lbl_london.Text = tstTime.ToString();
            lbl_london.Visible = true;

            
        }
    }
}