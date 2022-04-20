
namespace IPChange
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_get = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_subnet = new System.Windows.Forms.TextBox();
            this.textBox_gateway = new System.Windows.Forms.TextBox();
            this.button_ipconfig = new System.Windows.Forms.Button();
            this.checkBox_auto = new System.Windows.Forms.CheckBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.listView_IpList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_DNS_apply = new System.Windows.Forms.Button();
            this.button_DNS_delete = new System.Windows.Forms.Button();
            this.button_DNS_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_DNSname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MainDNS = new System.Windows.Forms.TextBox();
            this.label_MainDns = new System.Windows.Forms.Label();
            this.textBox_SubDNS = new System.Windows.Forms.TextBox();
            this.label_SubDns = new System.Windows.Forms.Label();
            this.listView_DNS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox_DNS = new System.Windows.Forms.CheckBox();
            this.comboBox_internetList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(512, 34);
            this.button_get.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(202, 28);
            this.button_get.TabIndex = 4;
            this.button_get.Text = "Get IP, Subnet, GateWay, DNS";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "SubNet : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "GateWay :";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Enabled = false;
            this.textBox_IP.Location = new System.Drawing.Point(158, 47);
            this.textBox_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(250, 28);
            this.textBox_IP.TabIndex = 8;
            this.textBox_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_subnet
            // 
            this.textBox_subnet.Enabled = false;
            this.textBox_subnet.Location = new System.Drawing.Point(158, 90);
            this.textBox_subnet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_subnet.Name = "textBox_subnet";
            this.textBox_subnet.Size = new System.Drawing.Size(250, 28);
            this.textBox_subnet.TabIndex = 9;
            this.textBox_subnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_gateway
            // 
            this.textBox_gateway.Enabled = false;
            this.textBox_gateway.Location = new System.Drawing.Point(158, 133);
            this.textBox_gateway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_gateway.Name = "textBox_gateway";
            this.textBox_gateway.Size = new System.Drawing.Size(250, 28);
            this.textBox_gateway.TabIndex = 10;
            this.textBox_gateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ipconfig
            // 
            this.button_ipconfig.Location = new System.Drawing.Point(722, 34);
            this.button_ipconfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ipconfig.Name = "button_ipconfig";
            this.button_ipconfig.Size = new System.Drawing.Size(220, 28);
            this.button_ipconfig.TabIndex = 11;
            this.button_ipconfig.Text = "ipconfig";
            this.button_ipconfig.UseVisualStyleBackColor = true;
            this.button_ipconfig.Click += new System.EventHandler(this.button_ipconfig_Click);
            // 
            // checkBox_auto
            // 
            this.checkBox_auto.AutoSize = true;
            this.checkBox_auto.Checked = true;
            this.checkBox_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_auto.Location = new System.Drawing.Point(21, 53);
            this.checkBox_auto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_auto.Name = "checkBox_auto";
            this.checkBox_auto.Size = new System.Drawing.Size(210, 22);
            this.checkBox_auto.TabIndex = 13;
            this.checkBox_auto.Text = "자동으로 IP 주소 받기";
            this.checkBox_auto.UseVisualStyleBackColor = true;
            this.checkBox_auto.CheckedChanged += new System.EventHandler(this.checkBox_auto_CheckedChanged);
            // 
            // button_apply
            // 
            this.button_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_apply.Location = new System.Drawing.Point(278, 4);
            this.button_apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(130, 40);
            this.button_apply.TabIndex = 14;
            this.button_apply.Text = "적용";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.listView_IpList);
            this.groupBox1.Controls.Add(this.checkBox_auto);
            this.groupBox1.Location = new System.Drawing.Point(42, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(900, 360);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP설정";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button_apply, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_save, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_delete, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(21, 294);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(412, 48);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // button_save
            // 
            this.button_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_save.Location = new System.Drawing.Point(4, 4);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(129, 40);
            this.button_save.TabIndex = 17;
            this.button_save.Text = "저장";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_delete.Location = new System.Drawing.Point(141, 4);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(129, 40);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_IP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_subnet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_gateway, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 103);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 172);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "이름 : ";
            // 
            // textBox_name
            // 
            this.textBox_name.Enabled = false;
            this.textBox_name.Location = new System.Drawing.Point(158, 4);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(250, 28);
            this.textBox_name.TabIndex = 15;
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView_IpList
            // 
            this.listView_IpList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.IP});
            this.listView_IpList.FullRowSelect = true;
            this.listView_IpList.HideSelection = false;
            this.listView_IpList.Location = new System.Drawing.Point(471, 53);
            this.listView_IpList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_IpList.Name = "listView_IpList";
            this.listView_IpList.Size = new System.Drawing.Size(410, 292);
            this.listView_IpList.TabIndex = 19;
            this.listView_IpList.UseCompatibleStateImageBehavior = false;
            this.listView_IpList.View = System.Windows.Forms.View.Details;
            this.listView_IpList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_IpList_MouseClick);
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 112;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IP.Width = 99;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.listView_DNS);
            this.groupBox2.Controls.Add(this.checkBox_DNS);
            this.groupBox2.Location = new System.Drawing.Point(42, 461);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(900, 322);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DNS 설정";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.button_DNS_apply, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_DNS_delete, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_DNS_Save, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(22, 250);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(412, 48);
            this.tableLayoutPanel4.TabIndex = 18;
            // 
            // button_DNS_apply
            // 
            this.button_DNS_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DNS_apply.Location = new System.Drawing.Point(278, 4);
            this.button_DNS_apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_DNS_apply.Name = "button_DNS_apply";
            this.button_DNS_apply.Size = new System.Drawing.Size(130, 40);
            this.button_DNS_apply.TabIndex = 24;
            this.button_DNS_apply.Text = "적용";
            this.button_DNS_apply.UseVisualStyleBackColor = true;
            this.button_DNS_apply.Click += new System.EventHandler(this.button_DNS_apply_Click);
            // 
            // button_DNS_delete
            // 
            this.button_DNS_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DNS_delete.Location = new System.Drawing.Point(141, 4);
            this.button_DNS_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_DNS_delete.Name = "button_DNS_delete";
            this.button_DNS_delete.Size = new System.Drawing.Size(129, 40);
            this.button_DNS_delete.TabIndex = 26;
            this.button_DNS_delete.Text = "삭제";
            this.button_DNS_delete.UseVisualStyleBackColor = true;
            this.button_DNS_delete.Click += new System.EventHandler(this.button_DNS_delete_Click);
            // 
            // button_DNS_Save
            // 
            this.button_DNS_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DNS_Save.Location = new System.Drawing.Point(4, 4);
            this.button_DNS_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_DNS_Save.Name = "button_DNS_Save";
            this.button_DNS_Save.Size = new System.Drawing.Size(129, 40);
            this.button_DNS_Save.TabIndex = 25;
            this.button_DNS_Save.Text = "저장";
            this.button_DNS_Save.UseVisualStyleBackColor = true;
            this.button_DNS_Save.Click += new System.EventHandler(this.button_DNS_Save_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_DNSname, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_MainDNS, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_MainDns, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_SubDNS, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_SubDns, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 84);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 145);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // textBox_DNSname
            // 
            this.textBox_DNSname.Enabled = false;
            this.textBox_DNSname.Location = new System.Drawing.Point(158, 4);
            this.textBox_DNSname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_DNSname.Name = "textBox_DNSname";
            this.textBox_DNSname.Size = new System.Drawing.Size(250, 28);
            this.textBox_DNSname.TabIndex = 20;
            this.textBox_DNSname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "이름 : ";
            // 
            // textBox_MainDNS
            // 
            this.textBox_MainDNS.Enabled = false;
            this.textBox_MainDNS.Location = new System.Drawing.Point(158, 52);
            this.textBox_MainDNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MainDNS.Name = "textBox_MainDNS";
            this.textBox_MainDNS.Size = new System.Drawing.Size(250, 28);
            this.textBox_MainDNS.TabIndex = 21;
            this.textBox_MainDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_MainDns
            // 
            this.label_MainDns.AutoSize = true;
            this.label_MainDns.Location = new System.Drawing.Point(4, 48);
            this.label_MainDns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MainDns.Name = "label_MainDns";
            this.label_MainDns.Size = new System.Drawing.Size(144, 18);
            this.label_MainDns.TabIndex = 19;
            this.label_MainDns.Text = "기본 DNS 서버 : ";
            // 
            // textBox_SubDNS
            // 
            this.textBox_SubDNS.Enabled = false;
            this.textBox_SubDNS.Location = new System.Drawing.Point(158, 100);
            this.textBox_SubDNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_SubDNS.Name = "textBox_SubDNS";
            this.textBox_SubDNS.Size = new System.Drawing.Size(250, 28);
            this.textBox_SubDNS.TabIndex = 22;
            this.textBox_SubDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_SubDns
            // 
            this.label_SubDns.AutoSize = true;
            this.label_SubDns.Location = new System.Drawing.Point(4, 96);
            this.label_SubDns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SubDns.Name = "label_SubDns";
            this.label_SubDns.Size = new System.Drawing.Size(144, 18);
            this.label_SubDns.TabIndex = 20;
            this.label_SubDns.Text = "보조 DNS 서버 : ";
            // 
            // listView_DNS
            // 
            this.listView_DNS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_DNS.FullRowSelect = true;
            this.listView_DNS.HideSelection = false;
            this.listView_DNS.Location = new System.Drawing.Point(472, 47);
            this.listView_DNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_DNS.Name = "listView_DNS";
            this.listView_DNS.Size = new System.Drawing.Size(410, 250);
            this.listView_DNS.TabIndex = 20;
            this.listView_DNS.UseCompatibleStateImageBehavior = false;
            this.listView_DNS.View = System.Windows.Forms.View.Details;
            this.listView_DNS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_DNS_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DNS";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 99;
            // 
            // checkBox_DNS
            // 
            this.checkBox_DNS.AutoSize = true;
            this.checkBox_DNS.Checked = true;
            this.checkBox_DNS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DNS.Location = new System.Drawing.Point(22, 47);
            this.checkBox_DNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_DNS.Name = "checkBox_DNS";
            this.checkBox_DNS.Size = new System.Drawing.Size(272, 22);
            this.checkBox_DNS.TabIndex = 0;
            this.checkBox_DNS.Text = "자동으로 DNS 서버 주소 받기";
            this.checkBox_DNS.UseVisualStyleBackColor = true;
            this.checkBox_DNS.CheckedChanged += new System.EventHandler(this.checkBox_DNS_CheckedChanged);
            // 
            // comboBox_internetList
            // 
            this.comboBox_internetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_internetList.FormattingEnabled = true;
            this.comboBox_internetList.Location = new System.Drawing.Point(51, 31);
            this.comboBox_internetList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_internetList.Name = "comboBox_internetList";
            this.comboBox_internetList.Size = new System.Drawing.Size(425, 26);
            this.comboBox_internetList.TabIndex = 18;
            this.comboBox_internetList.SelectionChangeCommitted += new System.EventHandler(this.comboBox_internetList_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 842);
            this.Controls.Add(this.comboBox_internetList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_ipconfig);
            this.Controls.Add(this.button_get);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_subnet;
        private System.Windows.Forms.TextBox textBox_gateway;
        private System.Windows.Forms.Button button_ipconfig;
        private System.Windows.Forms.CheckBox checkBox_auto;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_DNS;
        private System.Windows.Forms.Label label_MainDns;
        private System.Windows.Forms.TextBox textBox_SubDNS;
        private System.Windows.Forms.Label label_SubDns;
        private System.Windows.Forms.TextBox textBox_MainDNS;
        private System.Windows.Forms.ListView listView_IpList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.Button button_DNS_delete;
        private System.Windows.Forms.Button button_DNS_Save;
        private System.Windows.Forms.Button button_DNS_apply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DNSname;
        private System.Windows.Forms.ListView listView_DNS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBox_internetList;
    }
}

