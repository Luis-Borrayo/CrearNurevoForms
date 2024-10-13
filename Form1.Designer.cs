namespace CrearNurevoForms
{
    partial class FormularioPrincipal
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
            btnAbrirFormulario = new Button();
            SuspendLayout();
            // 
            // btnAbrirFormulario
            // 
            btnAbrirFormulario.Font = new Font("Centaur", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirFormulario.Location = new Point(175, 84);
            btnAbrirFormulario.Name = "btnAbrirFormulario";
            btnAbrirFormulario.Size = new Size(124, 50);
            btnAbrirFormulario.TabIndex = 0;
            btnAbrirFormulario.Text = "Abrir Nuevo Formulario";
            btnAbrirFormulario.UseVisualStyleBackColor = true;
            btnAbrirFormulario.Click += btnAbrirFormulario_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 236);
            Controls.Add(btnAbrirFormulario);
            IsMdiContainer = true;
            Name = "FormularioPrincipal";
            Text = "Form1";
            Load += FormularioPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirFormulario;
    }
}
