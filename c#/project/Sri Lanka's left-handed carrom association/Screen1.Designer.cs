
namespace PayMedia_technical_assessment
{
    partial class Screen1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FullName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.memberType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.addressinput = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.subButton = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(126, 164);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(89, 20);
            this.FullName.TabIndex = 0;
            this.FullName.Text = "Full Name";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(126, 202);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(75, 20);
            this.Address.TabIndex = 1;
            this.Address.Text = "Address";
            this.Address.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Membership Type";
            // 
            // memberType
            // 
            this.memberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberType.FormattingEnabled = true;
            this.memberType.Items.AddRange(new object[] {
            "VIP",
            "Gold",
            "General"});
            this.memberType.Location = new System.Drawing.Point(319, 359);
            this.memberType.Name = "memberType";
            this.memberType.Size = new System.Drawing.Size(103, 21);
            this.memberType.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(319, 318);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(319, 283);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(84, 21);
            this.Gender.TabIndex = 8;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(319, 242);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(165, 20);
            this.phoneNumber.TabIndex = 9;
            this.phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber_KeyPress);
            // 
            // addressinput
            // 
            this.addressinput.Location = new System.Drawing.Point(319, 202);
            this.addressinput.Name = "addressinput";
            this.addressinput.Size = new System.Drawing.Size(165, 20);
            this.addressinput.TabIndex = 10;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(319, 164);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 20);
            this.name.TabIndex = 11;
            // 
            // subButton
            // 
            this.subButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subButton.Location = new System.Drawing.Point(237, 428);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(137, 45);
            this.subButton.TabIndex = 12;
            this.subButton.Text = "Submit";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(183, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(324, 31);
            this.label24.TabIndex = 28;
            this.label24.Text = "Membership Application";
            // 
            // Screen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 586);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addressinput);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.memberType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.FullName);
            this.Name = "Screen1";
            this.Text = "Screen 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox memberType;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox addressinput;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Label label24;
    }
}

