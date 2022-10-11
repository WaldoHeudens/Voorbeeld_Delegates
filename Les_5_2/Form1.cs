namespace Les_5_2
{
    public partial class Form1 : Form
    {

        public delegate void RemedieDelegate(Student s, TimeSpan teLaat);

        public RemedieDelegate mijnDelegates = null;

        private Student student1 = new Student() { Id = 1, Name = "Stoute Jongen" };

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbRemedie.Text = "";
            if (mijnDelegates != null)
                mijnDelegates(student1, new TimeSpan(7,0,0,0));
        }

        public void DotNetAdvanced(Student s, TimeSpan veelTeLaat)
        {
            if (veelTeLaat > new TimeSpan(7,0,0,0))
            {
                tbRemedie.Text += "Dat was heel jammer voor "+ student1.ToString() + " maar we steken er geen tijd in. \r\n";
            }
            else
            {
                tbRemedie.Text += "Scheld " + student1.ToString() + " even uit. \r\n";
            }
        }

        public void Android(Student s, TimeSpan ookTeLaat)
        {
            tbRemedie.Text += "Zorg dat David een pint gaat pakken met " + student1.ToString()  + " \r\n";
        }

        public void ProjectIntro(Student s, TimeSpan ookTeLaat)
        {
            tbRemedie.Text += "Geef " + student1.ToString() + " een pak slaag. \r\n";
        }


        private void ClickOpCheckbox (object sender, EventArgs e)
        {
          
            if (sender == cbAndroid)
            {
                if (cbAndroid.Checked)
                    mijnDelegates += new RemedieDelegate(Android);
                else
                    mijnDelegates -= new RemedieDelegate(Android);
            }
            if (sender == cbDotNet)
            {
                if (cbDotNet.Checked)
                    mijnDelegates += new RemedieDelegate(DotNetAdvanced);
                else
                    mijnDelegates -= new RemedieDelegate(DotNetAdvanced);
            }
            if (sender == cbProjectIntro)
            {
                if (cbProjectIntro.Checked)
                    mijnDelegates += new RemedieDelegate(ProjectIntro);
                else
                    mijnDelegates -= new RemedieDelegate(ProjectIntro);
            }
        }
    }
}