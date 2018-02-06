using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navigator.View {
    public partial class frmNavigator : Form, INavigatorView {
        public frmNavigator() {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e) {
            this.Presenter.Navigate();
        }

        public Presenter.NavigatorPresenter Presenter {
            private get;
            set;
        }

        public string OriginPoint {
            get { return this.txtOriginPoint.Text; }
            set { this.txtOriginPoint.Text = value; }
        }

        public string Movements {
            get { return this.txtMovements.Text; }
            set { this.txtMovements.Text = value; }
        }

        public string ResultPoint {
            get { return this.lblOutput.Text; }
            set { this.lblOutput.Text = value; }
        }

        public void ShowErrorMessage(string errorMessage) {
            MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        public bool AutoUpdateOriginPoint {
            get { return this.chkAutoUpdateOriginPoint.Checked; }
        }
    }
}
