namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            lbsVerSolicitudesImportadas = new ListBox();
            btnImportarSolicitudes = new Button();
            label1 = new Label();
            label2 = new Label();
            btnConfirmarAtencion = new Button();
            lbSolicitudSeleccionado = new Label();
            lbsColaSolicitudesAAtender = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbsVerSolicitudesImportadas
            // 
            lbsVerSolicitudesImportadas.FormattingEnabled = true;
            lbsVerSolicitudesImportadas.HorizontalScrollbar = true;
            lbsVerSolicitudesImportadas.Location = new Point(12, 174);
            lbsVerSolicitudesImportadas.Name = "lbsVerSolicitudesImportadas";
            lbsVerSolicitudesImportadas.ScrollAlwaysVisible = true;
            lbsVerSolicitudesImportadas.Size = new Size(273, 264);
            lbsVerSolicitudesImportadas.TabIndex = 0;
            lbsVerSolicitudesImportadas.SelectedValueChanged += lbsVerSolicitudesImportadas_SelectedValueChanged;
            // 
            // btnImportarSolicitudes
            // 
            btnImportarSolicitudes.Location = new Point(12, 31);
            btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            btnImportarSolicitudes.Size = new Size(116, 57);
            btnImportarSolicitudes.TabIndex = 1;
            btnImportarSolicitudes.Text = "Importar Solicitudes ";
            btnImportarSolicitudes.UseVisualStyleBackColor = true;
            btnImportarSolicitudes.Click += btnImportarSolicitudes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 2;
            label1.Text = "Lista de solicitudes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 137);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Entrantes";
            // 
            // btnConfirmarAtencion
            // 
            btnConfirmarAtencion.Location = new Point(318, 298);
            btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            btnConfirmarAtencion.Size = new Size(115, 85);
            btnConfirmarAtencion.TabIndex = 4;
            btnConfirmarAtencion.Text = "Confirmar a cola de atencion  solicitud seleccionada";
            btnConfirmarAtencion.UseVisualStyleBackColor = true;
            btnConfirmarAtencion.Click += btnConfirmarAtencion_Click;
            // 
            // lbSolicitudSeleccionado
            // 
            lbSolicitudSeleccionado.BackColor = SystemColors.ActiveCaption;
            lbSolicitudSeleccionado.Location = new Point(301, 174);
            lbSolicitudSeleccionado.Name = "lbSolicitudSeleccionado";
            lbSolicitudSeleccionado.Size = new Size(149, 109);
            lbSolicitudSeleccionado.TabIndex = 5;
            lbSolicitudSeleccionado.Text = "Seleccione desde la lista";
            // 
            // lbsColaSolicitudesAAtender
            // 
            lbsColaSolicitudesAAtender.FormattingEnabled = true;
            lbsColaSolicitudesAAtender.Location = new Point(456, 174);
            lbsColaSolicitudesAAtender.Name = "lbsColaSolicitudesAAtender";
            lbsColaSolicitudesAAtender.Size = new Size(252, 264);
            lbsColaSolicitudesAAtender.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 137);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 7;
            label3.Text = "Cola de atencion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lbsColaSolicitudesAAtender);
            Controls.Add(lbSolicitudSeleccionado);
            Controls.Add(btnConfirmarAtencion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnImportarSolicitudes);
            Controls.Add(lbsVerSolicitudesImportadas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ListBox lbsVerSolicitudesImportadas;
        private Button btnImportarSolicitudes;
        private Label label1;
        private Label label2;
        private Button btnConfirmarAtencion;
        private Label lbSolicitudSeleccionado;
        private ListBox lbsColaSolicitudesAAtender;
        private Label label3;
    }
}
