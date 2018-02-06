namespace Navigator.View {
	partial class frmNavigator {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.txtMovements = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMovements = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.txtOriginPoint = new System.Windows.Forms.TextBox();
            this.chkAutoUpdateOriginPoint = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtMovements
            // 
            this.txtMovements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMovements.Location = new System.Drawing.Point(12, 109);
            this.txtMovements.Multiline = true;
            this.txtMovements.Name = "txtMovements";
            this.txtMovements.Size = new System.Drawing.Size(642, 54);
            this.txtMovements.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(473, 191);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(181, 44);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Processar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 182);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(239, 20);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Posição depois dos movimentos:";
            // 
            // lblMovements
            // 
            this.lblMovements.AutoSize = true;
            this.lblMovements.Location = new System.Drawing.Point(12, 86);
            this.lblMovements.Name = "lblMovements";
            this.lblMovements.Size = new System.Drawing.Size(475, 20);
            this.lblMovements.TabIndex = 3;
            this.lblMovements.Text = "Insira movimentos em formato [N,1] separados por ponto e vírgula:";
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutput.AutoSize = true;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(257, 178);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(79, 27);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "             ";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(12, 9);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(292, 20);
            this.lblOrigin.TabIndex = 5;
            this.lblOrigin.Text = "Insira ponto de origem em formato (0,0):";
            // 
            // txtOriginPoint
            // 
            this.txtOriginPoint.Location = new System.Drawing.Point(12, 32);
            this.txtOriginPoint.Name = "txtOriginPoint";
            this.txtOriginPoint.Size = new System.Drawing.Size(271, 26);
            this.txtOriginPoint.TabIndex = 0;
            // 
            // chkAutoUpdateOriginPoint
            // 
            this.chkAutoUpdateOriginPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoUpdateOriginPoint.AutoSize = true;
            this.chkAutoUpdateOriginPoint.Checked = true;
            this.chkAutoUpdateOriginPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoUpdateOriginPoint.Location = new System.Drawing.Point(16, 214);
            this.chkAutoUpdateOriginPoint.Name = "chkAutoUpdateOriginPoint";
            this.chkAutoUpdateOriginPoint.Size = new System.Drawing.Size(235, 24);
            this.chkAutoUpdateOriginPoint.TabIndex = 6;
            this.chkAutoUpdateOriginPoint.Text = "Auto-atualizar posição inicial";
            this.chkAutoUpdateOriginPoint.UseVisualStyleBackColor = true;
            // 
            // frmNavigator
            // 
            this.AcceptButton = this.btnProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 247);
            this.Controls.Add(this.chkAutoUpdateOriginPoint);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOriginPoint);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblMovements);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtMovements);
            this.Name = "frmNavigator";
            this.Text = "Navegador";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMovements;
		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblMovements;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Label lblOrigin;
		private System.Windows.Forms.TextBox txtOriginPoint;
		private System.Windows.Forms.CheckBox chkAutoUpdateOriginPoint;
	}
}

