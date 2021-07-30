
namespace RegistrationForm
{
    partial class Anketa
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_LastName = new System.Windows.Forms.TextBox();
            this.tbx_Company = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.pbx_Email = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_Calendar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbx_FirstName = new System.Windows.Forms.TextBox();
            this.tbx_Country = new System.Windows.Forms.TextBox();
            this.tbx_LiveAddress = new System.Windows.Forms.TextBox();
            this.tbx_WorkAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbx_City = new System.Windows.Forms.TextBox();
            this.gbx_ProgLanguages = new System.Windows.Forms.GroupBox();
            this.cbx_C = new System.Windows.Forms.CheckBox();
            this.cbx_WinForm = new System.Windows.Forms.CheckBox();
            this.cbx_Csharp = new System.Windows.Forms.CheckBox();
            this.cbx_Cplusplus = new System.Windows.Forms.CheckBox();
            this.cbx_WPF = new System.Windows.Forms.CheckBox();
            this.cbx_Java = new System.Windows.Forms.CheckBox();
            this.cbx_SQL = new System.Windows.Forms.CheckBox();
            this.cbx_JS = new System.Windows.Forms.CheckBox();
            this.cbx_HTML = new System.Windows.Forms.CheckBox();
            this.cbx_CSS = new System.Windows.Forms.CheckBox();
            this.cbx_Pyton = new System.Windows.Forms.CheckBox();
            this.cbx_Ruby = new System.Windows.Forms.CheckBox();
            this.cbx_TS = new System.Windows.Forms.CheckBox();
            this.cbx_VisualBasic = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbx_Languages = new System.Windows.Forms.GroupBox();
            this.cbx_Fr = new System.Windows.Forms.CheckBox();
            this.cbx_Eng = new System.Windows.Forms.CheckBox();
            this.cbx_Ru = new System.Windows.Forms.CheckBox();
            this.cbx_De = new System.Windows.Forms.CheckBox();
            this.cbx_Az = new System.Windows.Forms.CheckBox();
            this.cbx_Accept = new System.Windows.Forms.CheckBox();
            this.cbx_Fsharp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbx_ProgLanguages.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbx_Languages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_LastName
            // 
            this.tbx_LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_LastName.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_LastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_LastName.Location = new System.Drawing.Point(452, 79);
            this.tbx_LastName.Multiline = true;
            this.tbx_LastName.Name = "tbx_LastName";
            this.tbx_LastName.Size = new System.Drawing.Size(287, 21);
            this.tbx_LastName.TabIndex = 1;
            this.tbx_LastName.Text = "LAST NAME";
            this.tbx_LastName.TextChanged += new System.EventHandler(this.tbx_LastName_TextChanged);
            // 
            // tbx_Company
            // 
            this.tbx_Company.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Company.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Company.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_Company.Location = new System.Drawing.Point(225, 141);
            this.tbx_Company.Multiline = true;
            this.tbx_Company.Name = "tbx_Company";
            this.tbx_Company.Size = new System.Drawing.Size(514, 21);
            this.tbx_Company.TabIndex = 2;
            this.tbx_Company.Text = "COMPANY";
            this.tbx_Company.TextChanged += new System.EventHandler(this.tbx_Company_TextChanged);
            // 
            // tbx_Email
            // 
            this.tbx_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Email.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_Email.Location = new System.Drawing.Point(225, 194);
            this.tbx_Email.Multiline = true;
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(282, 21);
            this.tbx_Email.TabIndex = 3;
            this.tbx_Email.Text = "E-MAIL";
            this.tbx_Email.TextChanged += new System.EventHandler(this.tbx_Email_TextChanged);
            // 
            // pbx_Email
            // 
            this.pbx_Email.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Email.Image = global::RegistrationForm.Properties.Resources.email;
            this.pbx_Email.Location = new System.Drawing.Point(195, 191);
            this.pbx_Email.Name = "pbx_Email";
            this.pbx_Email.Size = new System.Drawing.Size(24, 24);
            this.pbx_Email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_Email.TabIndex = 4;
            this.pbx_Email.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RegistrationForm.Properties.Resources.business_and_trade;
            this.pictureBox1.Location = new System.Drawing.Point(195, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_Calendar
            // 
            this.dtp_Calendar.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtp_Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Calendar.Location = new System.Drawing.Point(577, 193);
            this.dtp_Calendar.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtp_Calendar.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_Calendar.Name = "dtp_Calendar";
            this.dtp_Calendar.Size = new System.Drawing.Size(161, 20);
            this.dtp_Calendar.TabIndex = 5;
            this.dtp_Calendar.ValueChanged += new System.EventHandler(this.dtp_Calendar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(574, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "DATE OF BIRTH";
            // 
            // mtb_Phone
            // 
            this.mtb_Phone.Culture = new System.Globalization.CultureInfo("az-Latn-AZ");
            this.mtb_Phone.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtb_Phone.Location = new System.Drawing.Point(204, 267);
            this.mtb_Phone.Mask = "(99000) 000-00-00";
            this.mtb_Phone.Name = "mtb_Phone";
            this.mtb_Phone.Size = new System.Drawing.Size(137, 20);
            this.mtb_Phone.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(201, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "PHONE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(204, 780);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "CENCEL";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(621, 780);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(118, 32);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RegistrationForm.Properties.Resources.edeferwf;
            this.pictureBox2.Location = new System.Drawing.Point(199, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // tbx_FirstName
            // 
            this.tbx_FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_FirstName.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_FirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_FirstName.Location = new System.Drawing.Point(225, 80);
            this.tbx_FirstName.Multiline = true;
            this.tbx_FirstName.Name = "tbx_FirstName";
            this.tbx_FirstName.Size = new System.Drawing.Size(210, 21);
            this.tbx_FirstName.TabIndex = 0;
            this.tbx_FirstName.Text = "FIRST NAME";
            this.tbx_FirstName.TextChanged += new System.EventHandler(this.tbx_FirstName_TextChanged);
            // 
            // tbx_Country
            // 
            this.tbx_Country.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Country.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Country.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_Country.Location = new System.Drawing.Point(11, 20);
            this.tbx_Country.Multiline = true;
            this.tbx_Country.Name = "tbx_Country";
            this.tbx_Country.Size = new System.Drawing.Size(182, 21);
            this.tbx_Country.TabIndex = 7;
            this.tbx_Country.Text = "COUNTRY";
            this.tbx_Country.TextChanged += new System.EventHandler(this.tbx_Country_TextChanged);
            // 
            // tbx_LiveAddress
            // 
            this.tbx_LiveAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_LiveAddress.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_LiveAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_LiveAddress.Location = new System.Drawing.Point(211, 20);
            this.tbx_LiveAddress.Multiline = true;
            this.tbx_LiveAddress.Name = "tbx_LiveAddress";
            this.tbx_LiveAddress.Size = new System.Drawing.Size(325, 21);
            this.tbx_LiveAddress.TabIndex = 8;
            this.tbx_LiveAddress.Text = "LIVE ADDRESS";
            this.tbx_LiveAddress.TextChanged += new System.EventHandler(this.tbx_LiveAddress_TextChanged);
            // 
            // tbx_WorkAddress
            // 
            this.tbx_WorkAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_WorkAddress.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_WorkAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_WorkAddress.Location = new System.Drawing.Point(211, 80);
            this.tbx_WorkAddress.Multiline = true;
            this.tbx_WorkAddress.Name = "tbx_WorkAddress";
            this.tbx_WorkAddress.Size = new System.Drawing.Size(325, 21);
            this.tbx_WorkAddress.TabIndex = 10;
            this.tbx_WorkAddress.Text = "WORK ADDRESS";
            this.tbx_WorkAddress.TextChanged += new System.EventHandler(this.tbx_WorkAddress_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(406, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 51);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENDER";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton1.Location = new System.Drawing.Point(11, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 18);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MALE";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton2.Location = new System.Drawing.Point(85, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 18);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "FEMALE";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // tbx_City
            // 
            this.tbx_City.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_City.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_City.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_City.Location = new System.Drawing.Point(11, 80);
            this.tbx_City.Multiline = true;
            this.tbx_City.Name = "tbx_City";
            this.tbx_City.Size = new System.Drawing.Size(182, 21);
            this.tbx_City.TabIndex = 9;
            this.tbx_City.Text = "CITY";
            this.tbx_City.TextChanged += new System.EventHandler(this.tbx_City_TextChanged);
            // 
            // gbx_ProgLanguages
            // 
            this.gbx_ProgLanguages.BackColor = System.Drawing.Color.Transparent;
            this.gbx_ProgLanguages.Controls.Add(this.cbx_Fsharp);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_VisualBasic);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_TS);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_Ruby);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_Pyton);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_CSS);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_HTML);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_JS);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_SQL);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_Java);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_WPF);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_Cplusplus);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_Csharp);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_WinForm);
            this.gbx_ProgLanguages.Controls.Add(this.cbx_C);
            this.gbx_ProgLanguages.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_ProgLanguages.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbx_ProgLanguages.Location = new System.Drawing.Point(444, 505);
            this.gbx_ProgLanguages.Name = "gbx_ProgLanguages";
            this.gbx_ProgLanguages.Size = new System.Drawing.Size(295, 145);
            this.gbx_ProgLanguages.TabIndex = 12;
            this.gbx_ProgLanguages.TabStop = false;
            this.gbx_ProgLanguages.Text = "PROGRAMMING LANGUAGES";
            // 
            // cbx_C
            // 
            this.cbx_C.AutoSize = true;
            this.cbx_C.Location = new System.Drawing.Point(15, 20);
            this.cbx_C.Name = "cbx_C";
            this.cbx_C.Size = new System.Drawing.Size(33, 18);
            this.cbx_C.TabIndex = 0;
            this.cbx_C.Text = "C";
            this.cbx_C.UseVisualStyleBackColor = true;
            this.cbx_C.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_WinForm
            // 
            this.cbx_WinForm.AutoSize = true;
            this.cbx_WinForm.Location = new System.Drawing.Point(15, 92);
            this.cbx_WinForm.Name = "cbx_WinForm";
            this.cbx_WinForm.Size = new System.Drawing.Size(78, 18);
            this.cbx_WinForm.TabIndex = 3;
            this.cbx_WinForm.Text = "WinForms";
            this.cbx_WinForm.UseVisualStyleBackColor = true;
            this.cbx_WinForm.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_Csharp
            // 
            this.cbx_Csharp.AutoSize = true;
            this.cbx_Csharp.Location = new System.Drawing.Point(15, 68);
            this.cbx_Csharp.Name = "cbx_Csharp";
            this.cbx_Csharp.Size = new System.Drawing.Size(42, 18);
            this.cbx_Csharp.TabIndex = 2;
            this.cbx_Csharp.Text = "C#";
            this.cbx_Csharp.UseVisualStyleBackColor = true;
            this.cbx_Csharp.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_Cplusplus
            // 
            this.cbx_Cplusplus.AutoSize = true;
            this.cbx_Cplusplus.Location = new System.Drawing.Point(15, 44);
            this.cbx_Cplusplus.Name = "cbx_Cplusplus";
            this.cbx_Cplusplus.Size = new System.Drawing.Size(45, 18);
            this.cbx_Cplusplus.TabIndex = 1;
            this.cbx_Cplusplus.Text = "C++";
            this.cbx_Cplusplus.UseVisualStyleBackColor = true;
            this.cbx_Cplusplus.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_WPF
            // 
            this.cbx_WPF.AutoSize = true;
            this.cbx_WPF.Location = new System.Drawing.Point(15, 116);
            this.cbx_WPF.Name = "cbx_WPF";
            this.cbx_WPF.Size = new System.Drawing.Size(48, 18);
            this.cbx_WPF.TabIndex = 4;
            this.cbx_WPF.Text = "WPF";
            this.cbx_WPF.UseVisualStyleBackColor = true;
            this.cbx_WPF.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_Java
            // 
            this.cbx_Java.AutoSize = true;
            this.cbx_Java.Location = new System.Drawing.Point(107, 20);
            this.cbx_Java.Name = "cbx_Java";
            this.cbx_Java.Size = new System.Drawing.Size(48, 18);
            this.cbx_Java.TabIndex = 5;
            this.cbx_Java.Text = "Java";
            this.cbx_Java.UseVisualStyleBackColor = true;
            this.cbx_Java.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_SQL
            // 
            this.cbx_SQL.AutoSize = true;
            this.cbx_SQL.Location = new System.Drawing.Point(107, 44);
            this.cbx_SQL.Name = "cbx_SQL";
            this.cbx_SQL.Size = new System.Drawing.Size(47, 18);
            this.cbx_SQL.TabIndex = 6;
            this.cbx_SQL.Text = "SQL";
            this.cbx_SQL.UseVisualStyleBackColor = true;
            this.cbx_SQL.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_JS
            // 
            this.cbx_JS.AutoSize = true;
            this.cbx_JS.Location = new System.Drawing.Point(107, 68);
            this.cbx_JS.Name = "cbx_JS";
            this.cbx_JS.Size = new System.Drawing.Size(80, 18);
            this.cbx_JS.TabIndex = 7;
            this.cbx_JS.Text = "JavaScript";
            this.cbx_JS.UseVisualStyleBackColor = true;
            this.cbx_JS.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_HTML
            // 
            this.cbx_HTML.AutoSize = true;
            this.cbx_HTML.Location = new System.Drawing.Point(107, 92);
            this.cbx_HTML.Name = "cbx_HTML";
            this.cbx_HTML.Size = new System.Drawing.Size(55, 18);
            this.cbx_HTML.TabIndex = 8;
            this.cbx_HTML.Text = "HTML";
            this.cbx_HTML.UseVisualStyleBackColor = true;
            this.cbx_HTML.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_CSS
            // 
            this.cbx_CSS.AutoSize = true;
            this.cbx_CSS.Location = new System.Drawing.Point(197, 68);
            this.cbx_CSS.Name = "cbx_CSS";
            this.cbx_CSS.Size = new System.Drawing.Size(47, 18);
            this.cbx_CSS.TabIndex = 12;
            this.cbx_CSS.Text = "CSS";
            this.cbx_CSS.UseVisualStyleBackColor = true;
            this.cbx_CSS.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_Pyton
            // 
            this.cbx_Pyton.AutoSize = true;
            this.cbx_Pyton.Location = new System.Drawing.Point(107, 116);
            this.cbx_Pyton.Name = "cbx_Pyton";
            this.cbx_Pyton.Size = new System.Drawing.Size(55, 18);
            this.cbx_Pyton.TabIndex = 9;
            this.cbx_Pyton.Text = "Pyton";
            this.cbx_Pyton.UseVisualStyleBackColor = true;
            this.cbx_Pyton.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_Ruby
            // 
            this.cbx_Ruby.AutoSize = true;
            this.cbx_Ruby.Location = new System.Drawing.Point(197, 20);
            this.cbx_Ruby.Name = "cbx_Ruby";
            this.cbx_Ruby.Size = new System.Drawing.Size(52, 18);
            this.cbx_Ruby.TabIndex = 10;
            this.cbx_Ruby.Text = "Ruby";
            this.cbx_Ruby.UseVisualStyleBackColor = true;
            this.cbx_Ruby.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_TS
            // 
            this.cbx_TS.AutoSize = true;
            this.cbx_TS.Location = new System.Drawing.Point(197, 44);
            this.cbx_TS.Name = "cbx_TS";
            this.cbx_TS.Size = new System.Drawing.Size(82, 18);
            this.cbx_TS.TabIndex = 11;
            this.cbx_TS.Text = "TypeScript";
            this.cbx_TS.UseVisualStyleBackColor = true;
            this.cbx_TS.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // cbx_VisualBasic
            // 
            this.cbx_VisualBasic.AutoSize = true;
            this.cbx_VisualBasic.Location = new System.Drawing.Point(197, 92);
            this.cbx_VisualBasic.Name = "cbx_VisualBasic";
            this.cbx_VisualBasic.Size = new System.Drawing.Size(90, 18);
            this.cbx_VisualBasic.TabIndex = 13;
            this.cbx_VisualBasic.Text = "Visual Basic";
            this.cbx_VisualBasic.UseVisualStyleBackColor = true;
            this.cbx_VisualBasic.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.tbx_Country);
            this.groupBox3.Controls.Add(this.tbx_LiveAddress);
            this.groupBox3.Controls.Add(this.tbx_City);
            this.groupBox3.Controls.Add(this.tbx_WorkAddress);
            this.groupBox3.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(195, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 122);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADDRESSES";
            // 
            // gbx_Languages
            // 
            this.gbx_Languages.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Languages.Controls.Add(this.cbx_Fr);
            this.gbx_Languages.Controls.Add(this.cbx_Eng);
            this.gbx_Languages.Controls.Add(this.cbx_Ru);
            this.gbx_Languages.Controls.Add(this.cbx_De);
            this.gbx_Languages.Controls.Add(this.cbx_Az);
            this.gbx_Languages.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Languages.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbx_Languages.Location = new System.Drawing.Point(199, 505);
            this.gbx_Languages.Name = "gbx_Languages";
            this.gbx_Languages.Size = new System.Drawing.Size(142, 145);
            this.gbx_Languages.TabIndex = 11;
            this.gbx_Languages.TabStop = false;
            this.gbx_Languages.Text = "LANGUAGES";
            // 
            // cbx_Fr
            // 
            this.cbx_Fr.AutoSize = true;
            this.cbx_Fr.Location = new System.Drawing.Point(15, 116);
            this.cbx_Fr.Name = "cbx_Fr";
            this.cbx_Fr.Size = new System.Drawing.Size(66, 18);
            this.cbx_Fr.TabIndex = 4;
            this.cbx_Fr.Text = "FRENCE";
            this.cbx_Fr.UseVisualStyleBackColor = true;
            this.cbx_Fr.CheckedChanged += new System.EventHandler(this.Languages);
            // 
            // cbx_Eng
            // 
            this.cbx_Eng.AutoSize = true;
            this.cbx_Eng.Location = new System.Drawing.Point(15, 44);
            this.cbx_Eng.Name = "cbx_Eng";
            this.cbx_Eng.Size = new System.Drawing.Size(72, 18);
            this.cbx_Eng.TabIndex = 1;
            this.cbx_Eng.Text = "ENGLISH";
            this.cbx_Eng.UseVisualStyleBackColor = true;
            this.cbx_Eng.CheckedChanged += new System.EventHandler(this.Languages);
            // 
            // cbx_Ru
            // 
            this.cbx_Ru.AutoSize = true;
            this.cbx_Ru.Location = new System.Drawing.Point(15, 68);
            this.cbx_Ru.Name = "cbx_Ru";
            this.cbx_Ru.Size = new System.Drawing.Size(72, 18);
            this.cbx_Ru.TabIndex = 2;
            this.cbx_Ru.Text = "RUSSIAN";
            this.cbx_Ru.UseVisualStyleBackColor = true;
            this.cbx_Ru.CheckedChanged += new System.EventHandler(this.Languages);
            // 
            // cbx_De
            // 
            this.cbx_De.AutoSize = true;
            this.cbx_De.Location = new System.Drawing.Point(15, 92);
            this.cbx_De.Name = "cbx_De";
            this.cbx_De.Size = new System.Drawing.Size(76, 18);
            this.cbx_De.TabIndex = 3;
            this.cbx_De.Text = "GERMANY";
            this.cbx_De.UseVisualStyleBackColor = true;
            this.cbx_De.CheckedChanged += new System.EventHandler(this.Languages);
            // 
            // cbx_Az
            // 
            this.cbx_Az.AutoSize = true;
            this.cbx_Az.Location = new System.Drawing.Point(15, 20);
            this.cbx_Az.Name = "cbx_Az";
            this.cbx_Az.Size = new System.Drawing.Size(89, 18);
            this.cbx_Az.TabIndex = 0;
            this.cbx_Az.Text = "AZERBAIJAN";
            this.cbx_Az.UseVisualStyleBackColor = true;
            this.cbx_Az.CheckedChanged += new System.EventHandler(this.Languages);
            // 
            // cbx_Accept
            // 
            this.cbx_Accept.AutoSize = true;
            this.cbx_Accept.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Accept.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Accept.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbx_Accept.Location = new System.Drawing.Point(206, 726);
            this.cbx_Accept.Name = "cbx_Accept";
            this.cbx_Accept.Size = new System.Drawing.Size(143, 18);
            this.cbx_Accept.TabIndex = 11;
            this.cbx_Accept.Text = "I accept all conditions";
            this.cbx_Accept.UseVisualStyleBackColor = false;
            this.cbx_Accept.CheckedChanged += new System.EventHandler(this.cbx_Accept_CheckedChanged);
            // 
            // cbx_Fsharp
            // 
            this.cbx_Fsharp.AutoSize = true;
            this.cbx_Fsharp.Location = new System.Drawing.Point(197, 116);
            this.cbx_Fsharp.Name = "cbx_Fsharp";
            this.cbx_Fsharp.Size = new System.Drawing.Size(41, 18);
            this.cbx_Fsharp.TabIndex = 14;
            this.cbx_Fsharp.Text = "F#";
            this.cbx_Fsharp.UseVisualStyleBackColor = true;
            this.cbx_Fsharp.CheckedChanged += new System.EventHandler(this.ProgrammingLanguages);
            // 
            // Anketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RegistrationForm.Properties.Resources.kelly_sikkema_4JxV3Gs42Ks_unsplash__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(822, 880);
            this.Controls.Add(this.cbx_Accept);
            this.Controls.Add(this.gbx_Languages);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbx_ProgLanguages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbx_FirstName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_Phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Calendar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbx_Email);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.tbx_Company);
            this.Controls.Add(this.tbx_LastName);
            this.Name = "Anketa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_ProgLanguages.ResumeLayout(false);
            this.gbx_ProgLanguages.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbx_Languages.ResumeLayout(false);
            this.gbx_Languages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_LastName;
        private System.Windows.Forms.TextBox tbx_Company;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.PictureBox pbx_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_Calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbx_FirstName;
        private System.Windows.Forms.TextBox tbx_Country;
        private System.Windows.Forms.TextBox tbx_LiveAddress;
        private System.Windows.Forms.TextBox tbx_WorkAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tbx_City;
        private System.Windows.Forms.GroupBox gbx_ProgLanguages;
        private System.Windows.Forms.CheckBox cbx_VisualBasic;
        private System.Windows.Forms.CheckBox cbx_TS;
        private System.Windows.Forms.CheckBox cbx_Ruby;
        private System.Windows.Forms.CheckBox cbx_Pyton;
        private System.Windows.Forms.CheckBox cbx_CSS;
        private System.Windows.Forms.CheckBox cbx_HTML;
        private System.Windows.Forms.CheckBox cbx_JS;
        private System.Windows.Forms.CheckBox cbx_SQL;
        private System.Windows.Forms.CheckBox cbx_Java;
        private System.Windows.Forms.CheckBox cbx_WPF;
        private System.Windows.Forms.CheckBox cbx_Cplusplus;
        private System.Windows.Forms.CheckBox cbx_Csharp;
        private System.Windows.Forms.CheckBox cbx_WinForm;
        private System.Windows.Forms.CheckBox cbx_C;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbx_Languages;
        private System.Windows.Forms.CheckBox cbx_Fr;
        private System.Windows.Forms.CheckBox cbx_Eng;
        private System.Windows.Forms.CheckBox cbx_Ru;
        private System.Windows.Forms.CheckBox cbx_De;
        private System.Windows.Forms.CheckBox cbx_Az;
        private System.Windows.Forms.CheckBox cbx_Accept;
        private System.Windows.Forms.CheckBox cbx_Fsharp;
    }
}

