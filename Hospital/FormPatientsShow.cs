using System.Windows.Forms;

namespace Hospital
{
    public partial class FormPatientsShow : Form
    {

        public FormPatientsShow()
        {
            InitializeComponent();
        }

        private void FormPatientsShow_Load(object sender, System.EventArgs e)
        {
            view2TableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.view2);
            view1TableAdapter.Fill(ведение_карточек_пациентов_в_больницеDataSet.view1);
        }
    }
}
