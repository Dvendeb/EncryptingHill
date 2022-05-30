
namespace HillEncriptacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtB_message = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_encrypting = new System.Windows.Forms.Button();
            this.txtB_textNumber = new System.Windows.Forms.TextBox();
            this.txtB_TextEncrypting = new System.Windows.Forms.TextBox();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.lbl_BodyOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Niagara Solid", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(245, 22);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(317, 40);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Encriptación y Desencriptación";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtB_message
            // 
            this.txtB_message.Location = new System.Drawing.Point(21, 87);
            this.txtB_message.Name = "txtB_message";
            this.txtB_message.Size = new System.Drawing.Size(624, 20);
            this.txtB_message.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_encrypting
            // 
            this.btn_encrypting.Location = new System.Drawing.Point(670, 85);
            this.btn_encrypting.Name = "btn_encrypting";
            this.btn_encrypting.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypting.TabIndex = 3;
            this.btn_encrypting.Text = "Encriptar";
            this.btn_encrypting.UseVisualStyleBackColor = true;
            this.btn_encrypting.Click += new System.EventHandler(this.btn_encrypting_Click);
            // 
            // txtB_textNumber
            // 
            this.txtB_textNumber.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtB_textNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_textNumber.Enabled = false;
            this.txtB_textNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtB_textNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtB_textNumber.Location = new System.Drawing.Point(21, 184);
            this.txtB_textNumber.Multiline = true;
            this.txtB_textNumber.Name = "txtB_textNumber";
            this.txtB_textNumber.Size = new System.Drawing.Size(724, 136);
            this.txtB_textNumber.TabIndex = 5;
            // 
            // txtB_TextEncrypting
            // 
            this.txtB_TextEncrypting.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtB_TextEncrypting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_TextEncrypting.Enabled = false;
            this.txtB_TextEncrypting.ForeColor = System.Drawing.SystemColors.Info;
            this.txtB_TextEncrypting.Location = new System.Drawing.Point(21, 381);
            this.txtB_TextEncrypting.Multiline = true;
            this.txtB_TextEncrypting.Name = "txtB_TextEncrypting";
            this.txtB_TextEncrypting.Size = new System.Drawing.Size(724, 140);
            this.txtB_TextEncrypting.TabIndex = 6;
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.BackColor = System.Drawing.Color.Black;
            this.lbl_Body.Font = new System.Drawing.Font("News706 BT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Body.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Body.Location = new System.Drawing.Point(14, 323);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(211, 42);
            this.lbl_Body.TabIndex = 7;
            this.lbl_Body.Text = "Encriptado";
            this.lbl_Body.Click += new System.EventHandler(this.lbl_Body_Click);
            // 
            // lbl_BodyOne
            // 
            this.lbl_BodyOne.AutoSize = true;
            this.lbl_BodyOne.Font = new System.Drawing.Font("News706 BT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BodyOne.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_BodyOne.Location = new System.Drawing.Point(18, 126);
            this.lbl_BodyOne.Name = "lbl_BodyOne";
            this.lbl_BodyOne.Size = new System.Drawing.Size(575, 45);
            this.lbl_BodyOne.TabIndex = 8;
            this.lbl_BodyOne.Text = "Transformacion Letra-Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(801, 541);
            this.Controls.Add(this.lbl_BodyOne);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.txtB_TextEncrypting);
            this.Controls.Add(this.txtB_textNumber);
            this.Controls.Add(this.btn_encrypting);
            this.Controls.Add(this.txtB_message);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txtB_message;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_encrypting;
        private System.Windows.Forms.TextBox txtB_textNumber;
        private System.Windows.Forms.TextBox txtB_TextEncrypting;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.Label lbl_BodyOne;
    }
}

