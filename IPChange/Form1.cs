using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Net;

namespace IPChange
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filepath);
        [DllImport("kernel32.dll")]
        private static extern uint GetPrivateProfileSectionNames(byte[] IpSections, uint nSize, string filepath);

        private string path = Application.StartupPath + @"\IPChange_IP.ini";
        private string DNSiniPath = Application.StartupPath + @"\IPChange_DNS.ini";
        private System.Diagnostics.Process m_process;
        private System.Diagnostics.ProcessStartInfo m_processInfo;
        private string savedName;
        private string savedDNSname;
        private List<string> listsectionName;
        private List<string> DNSlistsectionName;
        private List<string> dnsServerslist;
        private List<string> NetworkList;
        private IpconfigViewForm ipconfigView;
        private string SelectnetworkName;


        public Form1()
        {
            InitializeComponent();
            InitProcess();
            InitListView();
            InitDNSListView();
            InitCombobox();
        }

        public void InitListView()
        {
            listView_IpList.Items.Clear();
            listsectionName = getiniSectionNames().ToList();

            //전체 섹션가져와서 테이블에 업데이트
            foreach (string sectionName in listsectionName)
            {
                StringBuilder retVal = new StringBuilder();
                GetPrivateProfileString(sectionName, "IP", "def", retVal, 50, path);
                if (retVal.ToString() != "def")
                {
                    ListViewItem item = new ListViewItem(sectionName);
                    item.SubItems.Add(retVal.ToString());
                    listView_IpList.Items.Add(item);
                }
            }
        }

        public void InitDNSListView()
        {
            listView_DNS.Items.Clear();
            DNSlistsectionName = getDNSiniSectionNames().ToList();

            //전체 섹션가져와서 테이블에 업데이트
            foreach (string sectionName in DNSlistsectionName)
            {
                StringBuilder retVal = new StringBuilder();
                GetPrivateProfileString(sectionName, "Main DNS", "def", retVal, 50, DNSiniPath);
                if (retVal.ToString() != "def")
                {
                    ListViewItem item = new ListViewItem(sectionName);
                    item.SubItems.Add(retVal.ToString());
                    listView_DNS.Items.Add(item);
                }
            }
        }

        public void InitProcess()
        {
            m_processInfo = new System.Diagnostics.ProcessStartInfo();
            m_process = new System.Diagnostics.Process();

            m_processInfo.FileName = @"cmd";
            //cmd창 숨기기
            m_processInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden; 
            //cmd창을 띄우지않게 하기
            m_processInfo.CreateNoWindow = true; 
            m_processInfo.UseShellExecute = false;
            // cmd 데이터 받기
            m_processInfo.RedirectStandardOutput = true;
            // cmd 데이터 보내기
            m_processInfo.RedirectStandardInput = true;
            // cmd 오류내용 받기
            m_processInfo.RedirectStandardError = true;
            m_process.EnableRaisingEvents = false;
            m_process.StartInfo = m_processInfo;
        }

        public void InitCombobox()
        {
            NetworkList = new List<string>();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                NetworkList.Add(adapter.Name);
            }

            comboBox_internetList.Items.AddRange(NetworkList.ToArray());
        }

        private bool CMDStart(string text)
        {
            m_process.Start();
            m_process.StandardInput.Write(text + Environment.NewLine);
            m_process.StandardInput.Close();

            string resultValue = m_process.StandardOutput.ReadToEnd();  //실행결과 내용

            m_process.WaitForExit();
            m_process.Close();
            Console.WriteLine(resultValue);
            if (resultValue.Contains("틀립니다")||resultValue.Contains("잘못되었습니다"))
            {
                MessageBox.Show("잘못된 주소입니다.");
                return false;
            }
            return true;
           
        }

        private string[] getiniSectionNames()
        {
            byte[] bytearray = new byte[255];
            uint flag = GetPrivateProfileSectionNames(bytearray, 255, path);
            return Encoding.Default.GetString(bytearray).Split(new char[1] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
        }
        private string[] getDNSiniSectionNames()
        {
            byte[] bytearray = new byte[255];
            uint flag = GetPrivateProfileSectionNames(bytearray, 255, DNSiniPath);
            return Encoding.Default.GetString(bytearray).Split(new char[1] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
        }

        //ip dns 등등 가져오기
        private void button_get_Click(object sender, EventArgs e)
        {
            
            Searchaddress();
        }
        
        private void button_ipconfig_Click(object sender, EventArgs e)
        {
            ipconfigView = new IpconfigViewForm();
            string data = sendCommadIpconfig();
            ipconfigView.setText(data);
            ipconfigView.ShowDialog();
        }

        private string sendCommadIpconfig()
        {
            m_process.Start();
            m_process.StandardInput.Write("ipconfig /all" + Environment.NewLine);
            m_process.StandardInput.Close();

            // 결과 값을 리턴
            string resultValue = m_process.StandardOutput.ReadToEnd();

            m_process.WaitForExit();
            m_process.Close();

            return resultValue;
        }

        //ip적용버튼
        private void button_apply_Click(object sender, EventArgs e)
        {
            if (SelectnetworkName != null)
            {
                if (checkBox_auto.Checked == true)
                {
                    CMDStart($"netsh interface ip set address name = \"{SelectnetworkName}\" source = dhcp");
                    MessageBox.Show("적용되었습니다.");
                }

                else
                {
                    if (textBox_IP.Text == string.Empty)
                    {
                        MessageBox.Show("IP를 입력하세요");
                        return;
                    }
                    if (textBox_subnet.Text == string.Empty)
                    {
                        MessageBox.Show("subnet을 입력하세요");
                        return;
                    }
                    if (textBox_gateway.Text == string.Empty)
                    {
                        MessageBox.Show("gateway를 입력하세요");
                        return;
                    }
                    if (CMDStart($"netsh interface ip set address name = \"{SelectnetworkName}\" static {textBox_IP.Text} {textBox_subnet.Text} {textBox_gateway.Text}"))
                        MessageBox.Show("적용되었습니다.");
                }
            }
            else
                MessageBox.Show("네트워크를 선택하십시오");
        }

        //ip체크박스 클릭
        private void checkBox_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_auto.Checked == false)
            {
                textBox_name.Enabled = true;
                textBox_IP.Enabled = true;
                textBox_subnet.Enabled = true;
                textBox_gateway.Enabled = true;
            }

            else
            {
                textBox_name.Enabled = false;
                textBox_IP.Enabled = false;
                textBox_subnet.Enabled = false;
                textBox_gateway.Enabled = false;

                textBox_name.Text = string.Empty;
                textBox_IP.Text = string.Empty;
                textBox_gateway.Text = string.Empty;
                textBox_subnet.Text = string.Empty;
            }
        }

        //ip ini파일 읽기
        private void updateTextbox()
        {
            if (savedName != null)
            {
                StringBuilder retVal1 = new StringBuilder();
                StringBuilder retVal2 = new StringBuilder();
                StringBuilder retVal3 = new StringBuilder();

                GetPrivateProfileString(savedName, "IP", "def", retVal1, 50, path);
                GetPrivateProfileString(savedName, "Subnet", "def", retVal2, 50, path);
                GetPrivateProfileString(savedName, "GateWay", "def", retVal3, 50, path);

                textBox_name.Text = savedName;
                textBox_IP.Text = retVal1.ToString();
                textBox_subnet.Text = retVal2.ToString();
                textBox_gateway.Text = retVal3.ToString();
            }
        }

        //ip저장
        private void button_save_Click(object sender, EventArgs e)
        {
            if (checkBox_auto.Checked == false)
            {
                if (textBox_name.Text == string.Empty)
                {
                    MessageBox.Show("이름을 입력하세요");
                    return;
                }
                if (textBox_IP.Text == string.Empty)
                {
                    MessageBox.Show("IP를 입력하세요");
                    return;
                }
                if (textBox_subnet.Text == string.Empty)
                {
                    MessageBox.Show("subnet을 입력하세요");
                    return;
                }
                if (textBox_gateway.Text == string.Empty)
                {
                    MessageBox.Show("gateway를 입력하세요");
                    return;
                }

                long writeResult1 = WritePrivateProfileString(textBox_name.Text, "IP", textBox_IP.Text, path);
                long writeResult2 = WritePrivateProfileString(textBox_name.Text, "Subnet", textBox_subnet.Text, path);
                long writeResult3 = WritePrivateProfileString(textBox_name.Text, "GateWay", textBox_gateway.Text, path);

                InitListView();
            }
            else
            {
                MessageBox.Show("자동이 아닐때만 저장이 가능합니다.");
            }
        }

        //ip리스트 클릭
        private void listView_IpList_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView_IpList.SelectedItems;
            ListViewItem lvItem = items[0];
            savedName = lvItem.SubItems[0].Text;
            //리스트 요소 클릭시 textbox업데이트
            if (checkBox_auto.Checked == false)
                updateTextbox();
        }

        //ip리스트 삭제
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (savedName != null)
            {
                WritePrivateProfileString(savedName, null, null, path);    //ini에서 삭제
                InitListView();
            }

            else
            {
                MessageBox.Show("삭제할 목록을 클릭하세요");
            }
        }

        //DNSini파일 읽기
        private void updateDNSTextbox()
        {
            if (savedDNSname != null)
            {
                StringBuilder retVal1 = new StringBuilder();
                StringBuilder retVal2 = new StringBuilder();

                GetPrivateProfileString(savedDNSname, "Main DNS", "def", retVal1, 50, DNSiniPath);
                GetPrivateProfileString(savedDNSname, "Sub DNS", "def", retVal2, 50, DNSiniPath);

                textBox_DNSname.Text = savedDNSname;
                textBox_MainDNS.Text = retVal1.ToString();
                textBox_SubDNS.Text = retVal2.ToString();
            }
        }

        private void checkBox_DNS_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_DNS.Checked == true)
            {
                textBox_DNSname.Enabled = false;
                textBox_MainDNS.Enabled = false;
                textBox_SubDNS.Enabled = false;
                textBox_DNSname.Text = null;
                textBox_MainDNS.Text = null;
                textBox_SubDNS.Text = null;
            }
            else
            {
                textBox_DNSname.Enabled = true;
                textBox_MainDNS.Enabled = true;
                textBox_SubDNS.Enabled = true;
            }
        }


        //DNS 적용
        private void button_DNS_apply_Click(object sender, EventArgs e)
        {
            if (SelectnetworkName != null)
            {

                if (checkBox_DNS.Checked == true)
                {
                    CMDStart($"netsh interface ip set dns name = \"{SelectnetworkName}\" source=dhcp");
                    MessageBox.Show("적용되었습니다.");
                }
                else
                {
                    if (textBox_MainDNS.Text == null)
                    {
                        MessageBox.Show("기본 DNS 주소가 없습니다.");
                    }
                    else
                    {
                        if (textBox_SubDNS.Text == null)
                        {
                            MessageBox.Show("서브 DNS 주소가 없습니다.");
                        }
                        else
                        {
                            if (CMDStart($"netsh interface ip set dns name = \"{SelectnetworkName}\" static {textBox_MainDNS.Text}"))
                            {
                                if (CMDStart($"netsh interface ipv4 add dnsservers \"{SelectnetworkName}\" {textBox_SubDNS.Text} index = 2"))
                                {
                                    MessageBox.Show("적용되었습니다.");
                                }
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show("네트워크를 선택하십시오");
        }

        //DNS리스트 클릭
        private void listView_DNS_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView_DNS.SelectedItems;
            ListViewItem lvItem = items[0];
            savedDNSname = lvItem.SubItems[0].Text;

            //리스트 요소 클릭시 textbox업데이트
            if (checkBox_DNS.Checked == false)
                updateDNSTextbox();
        }

        //DNS저장
        private void button_DNS_Save_Click(object sender, EventArgs e)
        {
            if (checkBox_DNS.Checked == false)
            {
                if (textBox_DNSname.Text == string.Empty)
                {
                    MessageBox.Show("이름을 입력하세요");
                    return;
                }

                if (textBox_MainDNS.Text == string.Empty)
                {
                    MessageBox.Show("기본 DNS 주소를 입력하세요");
                    return;
                }

                if (textBox_SubDNS.Text == string.Empty)
                {
                    MessageBox.Show("보조 Dns 주소를 입력하세요");
                    return;
                }

                savedDNSname = textBox_DNSname.Text;
                WritePrivateProfileString(savedDNSname, "Main DNS", textBox_MainDNS.Text, DNSiniPath);
                WritePrivateProfileString(savedDNSname, "Sub DNS", textBox_SubDNS.Text, DNSiniPath);
                InitDNSListView();
            }
           
        }

        private void button_DNS_delete_Click(object sender, EventArgs e)
        {
            if (savedDNSname != null)
            {
                WritePrivateProfileString(savedDNSname, null, null, DNSiniPath);    //ini에서 삭제
                InitDNSListView();
            }

            else
            {
                MessageBox.Show("삭제할 목록을 클릭하세요");
            }
        }


        //IP,DNS 주소 찾기
        private void Searchaddress()
        {

            //사용 가능한 네트워크 인터페이스를 설명하는 개체가 들어있는 배열
            //발견된 인터페이스가 없으면 빈 배열
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                if (comboBox_internetList.SelectedItem== null)
                {
                    MessageBox.Show("네트워크를 선택하세요.");
                    break;
                }

                else if (adapter.Name == comboBox_internetList.SelectedItem.ToString())
                {
                    dnsServerslist = new List<string>();
                    List<string> IpList = new List<string>();

                    //해당 컴퓨터의 네트워크 인터페이스 정보
                    IPInterfaceProperties adapterProperites = adapter.GetIPProperties();
                    //해당 인터페이스에 대한 IPv4 네트워크 게이트웨이 주소를 가져옴
                    GatewayIPAddressInformationCollection gatewayAddresses = adapterProperites.GatewayAddresses;
                    //dhcp(Dynamic Host Configuration Protocol) 서버의 주소를 가져옴
                    IPAddressCollection dhcpServers = adapterProperites.DhcpServerAddresses;

                    //IPAddress형식의 집합을 저장, IPAddress : IP(Internet protocol)주소
                    //IPAddress형식의 집합을 저장, DNS address주소
                    IPAddressCollection dnsServers = adapterProperites.DnsAddresses;

                    if (dnsServers.Count > 0)
                    {
                        //dns리스트
                        foreach (IPAddress dns in dnsServers)
                        {
                            dnsServerslist.Add(dns.ToString());
                        }

                        //dhcpip
                        if (dhcpServers.Count > 0)
                        {
                            foreach (IPAddress ip in dhcpServers)
                            {
                                //MessageBox.Show(ip.ToString());
                                //Console.WriteLine(ip.ToString());
                                //IpList.Add(ip.ToString());
                            }
                        }

                        //gateway
                        if (gatewayAddresses.Count > 0)
                        {
                            foreach (GatewayIPAddressInformation address in gatewayAddresses)
                            {
                                IpList.Add(address.Address.ToString());
                                //textBox_gateway.Text = address.Address.ToString();
                            }
                        }

                        //ip,subnet
                        foreach (UnicastIPAddressInformation ip in adapterProperites.UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                //ip
                                IpList.Add(ip.Address.ToString());
                                if (ip.IPv4Mask != null)
                                {
                                    //서브넷 마스크
                                    IpList.Add(ip.IPv4Mask.ToString());
                                }
                            }
                        }
                    }

                    if (IpList.Count >= 3 && dnsServerslist.Count >= 2)
                    {
                        textBox_MainDNS.Text = dnsServerslist[0];
                        textBox_SubDNS.Text = dnsServerslist[1];
                        textBox_IP.Text = IpList[1];
                        textBox_subnet.Text = IpList[2];
                        textBox_gateway.Text = IpList[0];
                    }
                    break;
                }
            }
        }

        public bool getDnsDHCPstatus(IPInterfaceProperties adapterProperites)
        {
            //IsDynamicDnsEnabled 현재 설정이 자동이면 true 반환
            
            bool enable = adapterProperites.IsDynamicDnsEnabled;
            return enable;
        }

        public bool getIpDHCPstatus(IPInterfaceProperties adapterProperites)
        {
            //IsDhcpEnabled 현재 설정이 자동이면 true 반환
            
            bool enable;
            IPv4InterfaceProperties ipv4Properties = adapterProperites.GetIPv4Properties();
            enable = ipv4Properties.IsDhcpEnabled;
            return enable;
        }

        private void comboBox_internetList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox_MainDNS.Text = null;
            textBox_SubDNS.Text = null;
            textBox_DNSname.Text = null;

            textBox_name.Text = null;
            textBox_IP.Text = null;
            textBox_gateway.Text = null;
            textBox_subnet.Text = null;

            SelectnetworkName = comboBox_internetList.SelectedItem.ToString();
        }
    }
}
/* ManagementClass MC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            //ManagementObjectCollection MOC = MC.GetInstances();

            //foreach(ManagementObject MO in MOC)
            //{
            //    if(MO["IPAddress"] !=null)
            //    {
            //        if(MO["IPAddress"] is Array)
            //        {
            //            string[] addresses = (string[])MO["IPAddress"];
            //            string[] subnets = (string[])MO["IPSubnet"];
            //            string[] gateways = (string[])MO["DefaultIPGateway"];

            //            if(addresses != null && subnets !=null && gateways !=null)
            //            {
            //                textBox_name.Text = string.Empty;
            //                textBox_IP.Text = addresses[0];
            //                textBox_subnet.Text = subnets[0];
            //                textBox_gateway.Text = gateways[0];
            //            }
            //        }
            //    }
            //}
            */
