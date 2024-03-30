<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configurator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnGet = New Button()
        txtIP = New TextBox()
        btnSend = New Button()
        txtFrequency = New TextBox()
        txtResolution = New TextBox()
        txtFPS = New TextBox()
        txtEncode = New TextBox()
        txtBitrate = New TextBox()
        txtExposure = New TextBox()
        txtContrast = New TextBox()
        txtHue = New TextBox()
        txtSaturation = New TextBox()
        txtLuminance = New TextBox()
        txtPower = New TextBox()
        txtSensor = New TextBox()
        txtFreq24 = New TextBox()
        txtMCS = New TextBox()
        txtLDPC = New TextBox()
        txtSTBC = New TextBox()
        txtFECN = New TextBox()
        txtFECK = New TextBox()
        txtPower24 = New TextBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnRestartWFB = New Button()
        ComboBox9 = New ComboBox()
        ComboBox8 = New ComboBox()
        ComboBox7 = New ComboBox()
        ComboBox6 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        txtSaveFreq = New Button()
        TabPage2 = New TabPage()
        btnRestartMajestic = New Button()
        cmbLuminance = New ComboBox()
        cmbSaturation = New ComboBox()
        cmbHue = New ComboBox()
        cmbContrast = New ComboBox()
        cmbExposure = New ComboBox()
        cmbBitrate = New ComboBox()
        cmbCodec = New ComboBox()
        cmbFPS = New ComboBox()
        cmbResolution = New ComboBox()
        txtSaveCam = New Button()
        TabPage3 = New TabPage()
        btnUART2OFF = New Button()
        btnUART2 = New Button()
        txtSaveTLM = New Button()
        cmbMCSTLM = New ComboBox()
        cmbRouter = New ComboBox()
        cmbBaud = New ComboBox()
        cmbSerial = New ComboBox()
        txtMCSTLM = New TextBox()
        txtRouter = New TextBox()
        txtBaud = New TextBox()
        txtSerial = New TextBox()
        TabPage4 = New TabPage()
        txtFormat = New TextBox()
        cmbFormat = New ComboBox()
        Label2 = New Label()
        txtSaveVRX = New Button()
        cmbOSD = New ComboBox()
        cmbCodecVRX = New ComboBox()
        cmbResolutionVRX = New ComboBox()
        txtResolutionVRX = New TextBox()
        txtMavlinkVRX = New TextBox()
        txtCodecVRX = New TextBox()
        txtOSD = New TextBox()
        txtPortVRX = New TextBox()
        txtExtras = New TextBox()
        TabPage5 = New TabPage()
        btnGenerateKeys = New Button()
        btnSendKeys = New Button()
        btnReceiveKeys = New Button()
        btnUpdate = New Button()
        btnRead = New Button()
        Label1 = New Label()
        btnToolTip = New ToolTip(components)
        btnReboot = New Button()
        txtPassword = New TextBox()
        rBtnCam = New RadioButton()
        rBtnNVR = New RadioButton()
        rBtnRadxaZero3w = New RadioButton()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnGet
        ' 
        btnGet.BackColor = Color.Gold
        btnGet.FlatStyle = FlatStyle.Popup
        btnGet.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGet.Location = New Point(12, 408)
        btnGet.Name = "btnGet"
        btnGet.Size = New Size(60, 30)
        btnGet.TabIndex = 0
        btnGet.Text = "1. Fetch"
        btnToolTip.SetToolTip(btnGet, "Fetch the required files from the OpenIPC Camera")
        btnGet.UseVisualStyleBackColor = False
        ' 
        ' txtIP
        ' 
        txtIP.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtIP.BorderStyle = BorderStyle.FixedSingle
        txtIP.Font = New Font("Arial", 9F, FontStyle.Bold)
        txtIP.ForeColor = Color.White
        txtIP.Location = New Point(82, 383)
        txtIP.Name = "txtIP"
        txtIP.Size = New Size(77, 21)
        txtIP.TabIndex = 1
        txtIP.Text = "192.168.0.1"
        btnToolTip.SetToolTip(txtIP, "Type the OpenIPC Camera IP" & vbCrLf & "in a correct format XXX.XXX.XXX.XXX")
        ' 
        ' btnSend
        ' 
        btnSend.BackColor = Color.Gold
        btnSend.FlatStyle = FlatStyle.Popup
        btnSend.Font = New Font("Arial", 8.25F, FontStyle.Bold)
        btnSend.ForeColor = Color.Black
        btnSend.Location = New Point(142, 408)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(72, 30)
        btnSend.TabIndex = 2
        btnSend.Text = "4. Upload"
        btnToolTip.SetToolTip(btnSend, "Send the local files with the new " & vbCrLf & "settings to the OpenIPC camera")
        btnSend.UseVisualStyleBackColor = False
        ' 
        ' txtFrequency
        ' 
        txtFrequency.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtFrequency.BorderStyle = BorderStyle.FixedSingle
        txtFrequency.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtFrequency.Location = New Point(248, 20)
        txtFrequency.Name = "txtFrequency"
        txtFrequency.ReadOnly = True
        txtFrequency.Size = New Size(191, 20)
        txtFrequency.TabIndex = 3
        ' 
        ' txtResolution
        ' 
        txtResolution.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtResolution.BorderStyle = BorderStyle.FixedSingle
        txtResolution.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtResolution.Location = New Point(248, 20)
        txtResolution.Name = "txtResolution"
        txtResolution.ReadOnly = True
        txtResolution.Size = New Size(191, 20)
        txtResolution.TabIndex = 4
        ' 
        ' txtFPS
        ' 
        txtFPS.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtFPS.BorderStyle = BorderStyle.FixedSingle
        txtFPS.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtFPS.Location = New Point(248, 49)
        txtFPS.Name = "txtFPS"
        txtFPS.ReadOnly = True
        txtFPS.Size = New Size(191, 20)
        txtFPS.TabIndex = 5
        ' 
        ' txtEncode
        ' 
        txtEncode.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtEncode.BorderStyle = BorderStyle.FixedSingle
        txtEncode.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtEncode.Location = New Point(248, 78)
        txtEncode.Name = "txtEncode"
        txtEncode.ReadOnly = True
        txtEncode.Size = New Size(191, 20)
        txtEncode.TabIndex = 6
        ' 
        ' txtBitrate
        ' 
        txtBitrate.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtBitrate.BorderStyle = BorderStyle.FixedSingle
        txtBitrate.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtBitrate.Location = New Point(248, 107)
        txtBitrate.Name = "txtBitrate"
        txtBitrate.ReadOnly = True
        txtBitrate.Size = New Size(191, 20)
        txtBitrate.TabIndex = 7
        ' 
        ' txtExposure
        ' 
        txtExposure.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtExposure.BorderStyle = BorderStyle.FixedSingle
        txtExposure.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtExposure.Location = New Point(248, 136)
        txtExposure.Name = "txtExposure"
        txtExposure.ReadOnly = True
        txtExposure.Size = New Size(191, 20)
        txtExposure.TabIndex = 8
        ' 
        ' txtContrast
        ' 
        txtContrast.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtContrast.BorderStyle = BorderStyle.FixedSingle
        txtContrast.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtContrast.Location = New Point(248, 165)
        txtContrast.Name = "txtContrast"
        txtContrast.ReadOnly = True
        txtContrast.Size = New Size(191, 20)
        txtContrast.TabIndex = 9
        ' 
        ' txtHue
        ' 
        txtHue.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtHue.BorderStyle = BorderStyle.FixedSingle
        txtHue.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtHue.Location = New Point(248, 194)
        txtHue.Name = "txtHue"
        txtHue.ReadOnly = True
        txtHue.Size = New Size(191, 20)
        txtHue.TabIndex = 10
        ' 
        ' txtSaturation
        ' 
        txtSaturation.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtSaturation.BorderStyle = BorderStyle.FixedSingle
        txtSaturation.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtSaturation.Location = New Point(248, 223)
        txtSaturation.Name = "txtSaturation"
        txtSaturation.ReadOnly = True
        txtSaturation.Size = New Size(191, 20)
        txtSaturation.TabIndex = 11
        ' 
        ' txtLuminance
        ' 
        txtLuminance.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtLuminance.BorderStyle = BorderStyle.FixedSingle
        txtLuminance.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtLuminance.Location = New Point(248, 252)
        txtLuminance.Name = "txtLuminance"
        txtLuminance.ReadOnly = True
        txtLuminance.Size = New Size(191, 20)
        txtLuminance.TabIndex = 12
        ' 
        ' txtPower
        ' 
        txtPower.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtPower.BorderStyle = BorderStyle.FixedSingle
        txtPower.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtPower.Location = New Point(248, 49)
        txtPower.Name = "txtPower"
        txtPower.ReadOnly = True
        txtPower.Size = New Size(191, 20)
        txtPower.TabIndex = 13
        ' 
        ' txtSensor
        ' 
        txtSensor.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtSensor.BorderStyle = BorderStyle.FixedSingle
        txtSensor.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtSensor.Location = New Point(19, 281)
        txtSensor.Name = "txtSensor"
        txtSensor.ReadOnly = True
        txtSensor.Size = New Size(420, 20)
        txtSensor.TabIndex = 14
        ' 
        ' txtFreq24
        ' 
        txtFreq24.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtFreq24.BorderStyle = BorderStyle.FixedSingle
        txtFreq24.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtFreq24.Location = New Point(248, 78)
        txtFreq24.Name = "txtFreq24"
        txtFreq24.ReadOnly = True
        txtFreq24.Size = New Size(191, 20)
        txtFreq24.TabIndex = 16
        ' 
        ' txtMCS
        ' 
        txtMCS.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtMCS.BorderStyle = BorderStyle.FixedSingle
        txtMCS.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtMCS.Location = New Point(248, 136)
        txtMCS.Name = "txtMCS"
        txtMCS.ReadOnly = True
        txtMCS.Size = New Size(191, 20)
        txtMCS.TabIndex = 15
        ' 
        ' txtLDPC
        ' 
        txtLDPC.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtLDPC.BorderStyle = BorderStyle.FixedSingle
        txtLDPC.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtLDPC.Location = New Point(248, 194)
        txtLDPC.Name = "txtLDPC"
        txtLDPC.ReadOnly = True
        txtLDPC.Size = New Size(191, 20)
        txtLDPC.TabIndex = 18
        ' 
        ' txtSTBC
        ' 
        txtSTBC.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtSTBC.BorderStyle = BorderStyle.FixedSingle
        txtSTBC.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSTBC.Location = New Point(248, 165)
        txtSTBC.Name = "txtSTBC"
        txtSTBC.ReadOnly = True
        txtSTBC.Size = New Size(191, 20)
        txtSTBC.TabIndex = 17
        ' 
        ' txtFECN
        ' 
        txtFECN.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtFECN.BorderStyle = BorderStyle.FixedSingle
        txtFECN.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtFECN.Location = New Point(248, 252)
        txtFECN.Name = "txtFECN"
        txtFECN.ReadOnly = True
        txtFECN.Size = New Size(191, 20)
        txtFECN.TabIndex = 20
        ' 
        ' txtFECK
        ' 
        txtFECK.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtFECK.BorderStyle = BorderStyle.FixedSingle
        txtFECK.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtFECK.Location = New Point(248, 223)
        txtFECK.Name = "txtFECK"
        txtFECK.ReadOnly = True
        txtFECK.Size = New Size(191, 20)
        txtFECK.TabIndex = 19
        ' 
        ' txtPower24
        ' 
        txtPower24.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtPower24.BorderStyle = BorderStyle.FixedSingle
        txtPower24.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtPower24.Location = New Point(248, 107)
        txtPower24.Name = "txtPower24"
        txtPower24.ReadOnly = True
        txtPower24.Size = New Size(191, 20)
        txtPower24.TabIndex = 21
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        TabControl1.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 12)
        TabControl1.Multiline = True
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(490, 367)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabIndex = 22
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TabPage1.Controls.Add(btnRestartWFB)
        TabPage1.Controls.Add(ComboBox9)
        TabPage1.Controls.Add(ComboBox8)
        TabPage1.Controls.Add(ComboBox7)
        TabPage1.Controls.Add(ComboBox6)
        TabPage1.Controls.Add(ComboBox5)
        TabPage1.Controls.Add(ComboBox4)
        TabPage1.Controls.Add(ComboBox3)
        TabPage1.Controls.Add(ComboBox2)
        TabPage1.Controls.Add(ComboBox1)
        TabPage1.Controls.Add(txtSaveFreq)
        TabPage1.Controls.Add(txtFrequency)
        TabPage1.Controls.Add(txtPower24)
        TabPage1.Controls.Add(txtPower)
        TabPage1.Controls.Add(txtFECN)
        TabPage1.Controls.Add(txtMCS)
        TabPage1.Controls.Add(txtFECK)
        TabPage1.Controls.Add(txtFreq24)
        TabPage1.Controls.Add(txtLDPC)
        TabPage1.Controls.Add(txtSTBC)
        TabPage1.Location = New Point(4, 23)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(482, 340)
        TabPage1.TabIndex = 0
        TabPage1.Text = "WFB Settings"
        ' 
        ' btnRestartWFB
        ' 
        btnRestartWFB.BackColor = Color.Gold
        btnRestartWFB.FlatStyle = FlatStyle.Popup
        btnRestartWFB.Font = New Font("Arial", 8.25F, FontStyle.Bold)
        btnRestartWFB.Location = New Point(204, 310)
        btnRestartWFB.Name = "btnRestartWFB"
        btnRestartWFB.Size = New Size(111, 23)
        btnRestartWFB.TabIndex = 45
        btnRestartWFB.Text = "Restart WFB"
        btnToolTip.SetToolTip(btnRestartWFB, "Save the Majestic settings to the" & vbCrLf & "local file majestic.yaml file" & vbCrLf)
        btnRestartWFB.UseVisualStyleBackColor = False
        ' 
        ' ComboBox9
        ' 
        ComboBox9.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox9.FlatStyle = FlatStyle.Popup
        ComboBox9.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox9.FormattingEnabled = True
        ComboBox9.Location = New Point(19, 252)
        ComboBox9.Name = "ComboBox9"
        ComboBox9.Size = New Size(214, 22)
        ComboBox9.TabIndex = 34
        ' 
        ' ComboBox8
        ' 
        ComboBox8.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox8.FlatStyle = FlatStyle.Popup
        ComboBox8.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox8.FormattingEnabled = True
        ComboBox8.Location = New Point(19, 223)
        ComboBox8.Name = "ComboBox8"
        ComboBox8.Size = New Size(214, 22)
        ComboBox8.TabIndex = 33
        ' 
        ' ComboBox7
        ' 
        ComboBox7.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox7.FlatStyle = FlatStyle.Popup
        ComboBox7.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox7.FormattingEnabled = True
        ComboBox7.Location = New Point(19, 194)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New Size(214, 22)
        ComboBox7.TabIndex = 32
        ' 
        ' ComboBox6
        ' 
        ComboBox6.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox6.FlatStyle = FlatStyle.Popup
        ComboBox6.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(19, 165)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(214, 22)
        ComboBox6.TabIndex = 31
        ' 
        ' ComboBox5
        ' 
        ComboBox5.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox5.FlatStyle = FlatStyle.Popup
        ComboBox5.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(19, 136)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(214, 22)
        ComboBox5.TabIndex = 30
        ' 
        ' ComboBox4
        ' 
        ComboBox4.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox4.FlatStyle = FlatStyle.Popup
        ComboBox4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(19, 106)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(214, 22)
        ComboBox4.TabIndex = 29
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox3.FlatStyle = FlatStyle.Popup
        ComboBox3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(19, 77)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(214, 22)
        ComboBox3.TabIndex = 28
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox2.FlatStyle = FlatStyle.Popup
        ComboBox2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(19, 48)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(214, 22)
        ComboBox2.TabIndex = 27
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ComboBox1.FlatStyle = FlatStyle.Popup
        ComboBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(19, 20)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(214, 22)
        ComboBox1.TabIndex = 26
        ' 
        ' txtSaveFreq
        ' 
        txtSaveFreq.BackColor = Color.Gold
        txtSaveFreq.FlatStyle = FlatStyle.Popup
        txtSaveFreq.Font = New Font("Arial", 8.25F, FontStyle.Bold)
        txtSaveFreq.Location = New Point(140, 310)
        txtSaveFreq.Name = "txtSaveFreq"
        txtSaveFreq.Size = New Size(58, 23)
        txtSaveFreq.TabIndex = 25
        txtSaveFreq.Text = "3. Save"
        btnToolTip.SetToolTip(txtSaveFreq, "Save the WFB settings to the" & vbCrLf & "local wfb.conf file")
        txtSaveFreq.UseVisualStyleBackColor = False
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TabPage2.Controls.Add(btnRestartMajestic)
        TabPage2.Controls.Add(cmbLuminance)
        TabPage2.Controls.Add(cmbSaturation)
        TabPage2.Controls.Add(cmbHue)
        TabPage2.Controls.Add(cmbContrast)
        TabPage2.Controls.Add(cmbExposure)
        TabPage2.Controls.Add(cmbBitrate)
        TabPage2.Controls.Add(cmbCodec)
        TabPage2.Controls.Add(cmbFPS)
        TabPage2.Controls.Add(cmbResolution)
        TabPage2.Controls.Add(txtSaveCam)
        TabPage2.Controls.Add(txtResolution)
        TabPage2.Controls.Add(txtSensor)
        TabPage2.Controls.Add(txtFPS)
        TabPage2.Controls.Add(txtLuminance)
        TabPage2.Controls.Add(txtEncode)
        TabPage2.Controls.Add(txtSaturation)
        TabPage2.Controls.Add(txtBitrate)
        TabPage2.Controls.Add(txtHue)
        TabPage2.Controls.Add(txtExposure)
        TabPage2.Controls.Add(txtContrast)
        TabPage2.Location = New Point(4, 23)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(482, 340)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Camera Settings"
        ' 
        ' btnRestartMajestic
        ' 
        btnRestartMajestic.BackColor = Color.Gold
        btnRestartMajestic.FlatStyle = FlatStyle.Popup
        btnRestartMajestic.Location = New Point(204, 310)
        btnRestartMajestic.Name = "btnRestartMajestic"
        btnRestartMajestic.Size = New Size(111, 23)
        btnRestartMajestic.TabIndex = 44
        btnRestartMajestic.Text = "Restart Majestic"
        btnToolTip.SetToolTip(btnRestartMajestic, "Save the Majestic settings to the" & vbCrLf & "local file majestic.yaml file" & vbCrLf)
        btnRestartMajestic.UseVisualStyleBackColor = False
        ' 
        ' cmbLuminance
        ' 
        cmbLuminance.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbLuminance.FlatStyle = FlatStyle.Popup
        cmbLuminance.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbLuminance.FormattingEnabled = True
        cmbLuminance.Location = New Point(19, 252)
        cmbLuminance.Name = "cmbLuminance"
        cmbLuminance.Size = New Size(214, 22)
        cmbLuminance.TabIndex = 43
        ' 
        ' cmbSaturation
        ' 
        cmbSaturation.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbSaturation.FlatStyle = FlatStyle.Popup
        cmbSaturation.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbSaturation.FormattingEnabled = True
        cmbSaturation.Location = New Point(19, 223)
        cmbSaturation.Name = "cmbSaturation"
        cmbSaturation.Size = New Size(214, 22)
        cmbSaturation.TabIndex = 42
        ' 
        ' cmbHue
        ' 
        cmbHue.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbHue.FlatStyle = FlatStyle.Popup
        cmbHue.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbHue.FormattingEnabled = True
        cmbHue.Location = New Point(19, 194)
        cmbHue.Name = "cmbHue"
        cmbHue.Size = New Size(214, 22)
        cmbHue.TabIndex = 41
        ' 
        ' cmbContrast
        ' 
        cmbContrast.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbContrast.FlatStyle = FlatStyle.Popup
        cmbContrast.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbContrast.FormattingEnabled = True
        cmbContrast.Location = New Point(19, 165)
        cmbContrast.Name = "cmbContrast"
        cmbContrast.Size = New Size(214, 22)
        cmbContrast.TabIndex = 40
        ' 
        ' cmbExposure
        ' 
        cmbExposure.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbExposure.FlatStyle = FlatStyle.Popup
        cmbExposure.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbExposure.FormattingEnabled = True
        cmbExposure.Location = New Point(19, 136)
        cmbExposure.Name = "cmbExposure"
        cmbExposure.Size = New Size(214, 22)
        cmbExposure.TabIndex = 39
        ' 
        ' cmbBitrate
        ' 
        cmbBitrate.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbBitrate.FlatStyle = FlatStyle.Popup
        cmbBitrate.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbBitrate.FormattingEnabled = True
        cmbBitrate.Location = New Point(19, 106)
        cmbBitrate.Name = "cmbBitrate"
        cmbBitrate.Size = New Size(214, 22)
        cmbBitrate.TabIndex = 38
        ' 
        ' cmbCodec
        ' 
        cmbCodec.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbCodec.FlatStyle = FlatStyle.Popup
        cmbCodec.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbCodec.FormattingEnabled = True
        cmbCodec.Location = New Point(19, 77)
        cmbCodec.Name = "cmbCodec"
        cmbCodec.Size = New Size(214, 22)
        cmbCodec.TabIndex = 37
        ' 
        ' cmbFPS
        ' 
        cmbFPS.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbFPS.FlatStyle = FlatStyle.Popup
        cmbFPS.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbFPS.FormattingEnabled = True
        cmbFPS.Location = New Point(19, 48)
        cmbFPS.Name = "cmbFPS"
        cmbFPS.Size = New Size(214, 22)
        cmbFPS.TabIndex = 36
        ' 
        ' cmbResolution
        ' 
        cmbResolution.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbResolution.FlatStyle = FlatStyle.Popup
        cmbResolution.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cmbResolution.FormattingEnabled = True
        cmbResolution.Location = New Point(19, 20)
        cmbResolution.Name = "cmbResolution"
        cmbResolution.Size = New Size(214, 22)
        cmbResolution.TabIndex = 35
        ' 
        ' txtSaveCam
        ' 
        txtSaveCam.BackColor = Color.Gold
        txtSaveCam.FlatStyle = FlatStyle.Popup
        txtSaveCam.Location = New Point(140, 310)
        txtSaveCam.Name = "txtSaveCam"
        txtSaveCam.Size = New Size(58, 23)
        txtSaveCam.TabIndex = 26
        txtSaveCam.Text = "3. Save"
        btnToolTip.SetToolTip(txtSaveCam, "Save the Majestic settings to the" & vbCrLf & "local file majestic.yaml file" & vbCrLf)
        txtSaveCam.UseVisualStyleBackColor = False
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TabPage3.Controls.Add(btnUART2OFF)
        TabPage3.Controls.Add(btnUART2)
        TabPage3.Controls.Add(txtSaveTLM)
        TabPage3.Controls.Add(cmbMCSTLM)
        TabPage3.Controls.Add(cmbRouter)
        TabPage3.Controls.Add(cmbBaud)
        TabPage3.Controls.Add(cmbSerial)
        TabPage3.Controls.Add(txtMCSTLM)
        TabPage3.Controls.Add(txtRouter)
        TabPage3.Controls.Add(txtBaud)
        TabPage3.Controls.Add(txtSerial)
        TabPage3.Location = New Point(4, 23)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.RightToLeft = RightToLeft.No
        TabPage3.Size = New Size(482, 340)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Telemetry"
        ' 
        ' btnUART2OFF
        ' 
        btnUART2OFF.BackColor = Color.Gold
        btnUART2OFF.FlatStyle = FlatStyle.Popup
        btnUART2OFF.Location = New Point(322, 301)
        btnUART2OFF.Name = "btnUART2OFF"
        btnUART2OFF.Size = New Size(117, 30)
        btnUART2OFF.TabIndex = 42
        btnUART2OFF.Text = "Disable UART2"
        btnToolTip.SetToolTip(btnUART2OFF, "Disable UART2 serial port" & vbCrLf & "Must also be selected to the" & vbCrLf & "Serial Selector")
        btnUART2OFF.UseVisualStyleBackColor = False
        ' 
        ' btnUART2
        ' 
        btnUART2.BackColor = Color.Gold
        btnUART2.FlatStyle = FlatStyle.Popup
        btnUART2.Location = New Point(322, 265)
        btnUART2.Name = "btnUART2"
        btnUART2.Size = New Size(117, 30)
        btnUART2.TabIndex = 41
        btnUART2.Text = "Enable UART2"
        btnToolTip.SetToolTip(btnUART2, "Enable UART2 serial port" & vbCrLf & "Must also be selected to the" & vbCrLf & "Serial Selector")
        btnUART2.UseVisualStyleBackColor = False
        ' 
        ' txtSaveTLM
        ' 
        txtSaveTLM.BackColor = Color.Gold
        txtSaveTLM.FlatStyle = FlatStyle.Popup
        txtSaveTLM.Location = New Point(140, 310)
        txtSaveTLM.Name = "txtSaveTLM"
        txtSaveTLM.Size = New Size(58, 23)
        txtSaveTLM.TabIndex = 40
        txtSaveTLM.Text = "3. Save"
        btnToolTip.SetToolTip(txtSaveTLM, "Save the Telemetry settings to the" & vbCrLf & "local file telemetry.conf file" & vbCrLf)
        txtSaveTLM.UseVisualStyleBackColor = False
        ' 
        ' cmbMCSTLM
        ' 
        cmbMCSTLM.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbMCSTLM.FlatStyle = FlatStyle.Popup
        cmbMCSTLM.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        cmbMCSTLM.FormattingEnabled = True
        cmbMCSTLM.Location = New Point(19, 107)
        cmbMCSTLM.Name = "cmbMCSTLM"
        cmbMCSTLM.Size = New Size(214, 22)
        cmbMCSTLM.TabIndex = 39
        ' 
        ' cmbRouter
        ' 
        cmbRouter.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbRouter.FlatStyle = FlatStyle.Popup
        cmbRouter.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        cmbRouter.FormattingEnabled = True
        cmbRouter.Location = New Point(19, 78)
        cmbRouter.Name = "cmbRouter"
        cmbRouter.Size = New Size(214, 22)
        cmbRouter.TabIndex = 38
        ' 
        ' cmbBaud
        ' 
        cmbBaud.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbBaud.FlatStyle = FlatStyle.Popup
        cmbBaud.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        cmbBaud.FormattingEnabled = True
        cmbBaud.Location = New Point(19, 49)
        cmbBaud.Name = "cmbBaud"
        cmbBaud.Size = New Size(214, 22)
        cmbBaud.TabIndex = 37
        ' 
        ' cmbSerial
        ' 
        cmbSerial.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbSerial.FlatStyle = FlatStyle.Popup
        cmbSerial.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        cmbSerial.FormattingEnabled = True
        cmbSerial.Location = New Point(19, 20)
        cmbSerial.Name = "cmbSerial"
        cmbSerial.Size = New Size(214, 22)
        cmbSerial.TabIndex = 36
        ' 
        ' txtMCSTLM
        ' 
        txtMCSTLM.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtMCSTLM.BorderStyle = BorderStyle.FixedSingle
        txtMCSTLM.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtMCSTLM.Location = New Point(248, 107)
        txtMCSTLM.Name = "txtMCSTLM"
        txtMCSTLM.ReadOnly = True
        txtMCSTLM.Size = New Size(191, 20)
        txtMCSTLM.TabIndex = 8
        ' 
        ' txtRouter
        ' 
        txtRouter.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtRouter.BorderStyle = BorderStyle.FixedSingle
        txtRouter.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtRouter.Location = New Point(248, 78)
        txtRouter.Name = "txtRouter"
        txtRouter.ReadOnly = True
        txtRouter.Size = New Size(191, 20)
        txtRouter.TabIndex = 7
        ' 
        ' txtBaud
        ' 
        txtBaud.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtBaud.BorderStyle = BorderStyle.FixedSingle
        txtBaud.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtBaud.Location = New Point(248, 49)
        txtBaud.Name = "txtBaud"
        txtBaud.ReadOnly = True
        txtBaud.Size = New Size(191, 20)
        txtBaud.TabIndex = 6
        ' 
        ' txtSerial
        ' 
        txtSerial.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtSerial.BorderStyle = BorderStyle.FixedSingle
        txtSerial.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtSerial.Location = New Point(248, 20)
        txtSerial.Name = "txtSerial"
        txtSerial.ReadOnly = True
        txtSerial.Size = New Size(191, 20)
        txtSerial.TabIndex = 5
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TabPage4.Controls.Add(txtFormat)
        TabPage4.Controls.Add(cmbFormat)
        TabPage4.Controls.Add(Label2)
        TabPage4.Controls.Add(txtSaveVRX)
        TabPage4.Controls.Add(cmbOSD)
        TabPage4.Controls.Add(cmbCodecVRX)
        TabPage4.Controls.Add(cmbResolutionVRX)
        TabPage4.Controls.Add(txtResolutionVRX)
        TabPage4.Controls.Add(txtMavlinkVRX)
        TabPage4.Controls.Add(txtCodecVRX)
        TabPage4.Controls.Add(txtOSD)
        TabPage4.Controls.Add(txtPortVRX)
        TabPage4.Controls.Add(txtExtras)
        TabPage4.Location = New Point(4, 23)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(482, 340)
        TabPage4.TabIndex = 3
        TabPage4.Text = "VRX"
        ' 
        ' txtFormat
        ' 
        txtFormat.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtFormat.BorderStyle = BorderStyle.FixedSingle
        txtFormat.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtFormat.Location = New Point(248, 107)
        txtFormat.Name = "txtFormat"
        txtFormat.ReadOnly = True
        txtFormat.Size = New Size(191, 20)
        txtFormat.TabIndex = 56
        ' 
        ' cmbFormat
        ' 
        cmbFormat.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbFormat.FlatStyle = FlatStyle.Popup
        cmbFormat.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        cmbFormat.FormattingEnabled = True
        cmbFormat.Location = New Point(19, 107)
        cmbFormat.Name = "cmbFormat"
        cmbFormat.Size = New Size(214, 22)
        cmbFormat.TabIndex = 55
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(19, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(424, 14)
        Label2.TabIndex = 54
        Label2.Text = "Be careful what you are changing in the fields below. It could break the VRX."
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtSaveVRX
        ' 
        txtSaveVRX.BackColor = Color.Gold
        txtSaveVRX.FlatStyle = FlatStyle.Popup
        txtSaveVRX.ForeColor = Color.Black
        txtSaveVRX.Location = New Point(140, 310)
        txtSaveVRX.Name = "txtSaveVRX"
        txtSaveVRX.Size = New Size(58, 23)
        txtSaveVRX.TabIndex = 53
        txtSaveVRX.Text = "3. Save"
        btnToolTip.SetToolTip(txtSaveVRX, "Save the WFB settings to the" & vbCrLf & "local wfb.conf file")
        txtSaveVRX.UseVisualStyleBackColor = False
        ' 
        ' cmbOSD
        ' 
        cmbOSD.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbOSD.FlatStyle = FlatStyle.Popup
        cmbOSD.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        cmbOSD.FormattingEnabled = True
        cmbOSD.Location = New Point(19, 78)
        cmbOSD.Name = "cmbOSD"
        cmbOSD.Size = New Size(214, 22)
        cmbOSD.TabIndex = 48
        ' 
        ' cmbCodecVRX
        ' 
        cmbCodecVRX.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbCodecVRX.FlatStyle = FlatStyle.Popup
        cmbCodecVRX.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        cmbCodecVRX.FormattingEnabled = True
        cmbCodecVRX.Location = New Point(19, 48)
        cmbCodecVRX.Name = "cmbCodecVRX"
        cmbCodecVRX.Size = New Size(214, 22)
        cmbCodecVRX.TabIndex = 45
        ' 
        ' cmbResolutionVRX
        ' 
        cmbResolutionVRX.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbResolutionVRX.FlatStyle = FlatStyle.Popup
        cmbResolutionVRX.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        cmbResolutionVRX.FormattingEnabled = True
        cmbResolutionVRX.Location = New Point(19, 20)
        cmbResolutionVRX.Name = "cmbResolutionVRX"
        cmbResolutionVRX.Size = New Size(214, 22)
        cmbResolutionVRX.TabIndex = 44
        ' 
        ' txtResolutionVRX
        ' 
        txtResolutionVRX.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtResolutionVRX.BorderStyle = BorderStyle.FixedSingle
        txtResolutionVRX.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtResolutionVRX.Location = New Point(248, 20)
        txtResolutionVRX.Name = "txtResolutionVRX"
        txtResolutionVRX.ReadOnly = True
        txtResolutionVRX.Size = New Size(191, 20)
        txtResolutionVRX.TabIndex = 35
        ' 
        ' txtMavlinkVRX
        ' 
        txtMavlinkVRX.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtMavlinkVRX.BorderStyle = BorderStyle.FixedSingle
        txtMavlinkVRX.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtMavlinkVRX.Location = New Point(248, 252)
        txtMavlinkVRX.Name = "txtMavlinkVRX"
        txtMavlinkVRX.Size = New Size(191, 20)
        txtMavlinkVRX.TabIndex = 43
        ' 
        ' txtCodecVRX
        ' 
        txtCodecVRX.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtCodecVRX.BorderStyle = BorderStyle.FixedSingle
        txtCodecVRX.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtCodecVRX.Location = New Point(248, 49)
        txtCodecVRX.Name = "txtCodecVRX"
        txtCodecVRX.ReadOnly = True
        txtCodecVRX.Size = New Size(191, 20)
        txtCodecVRX.TabIndex = 36
        ' 
        ' txtOSD
        ' 
        txtOSD.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtOSD.BorderStyle = BorderStyle.FixedSingle
        txtOSD.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtOSD.Location = New Point(248, 78)
        txtOSD.Name = "txtOSD"
        txtOSD.ReadOnly = True
        txtOSD.Size = New Size(191, 20)
        txtOSD.TabIndex = 37
        ' 
        ' txtPortVRX
        ' 
        txtPortVRX.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtPortVRX.BorderStyle = BorderStyle.FixedSingle
        txtPortVRX.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtPortVRX.Location = New Point(19, 252)
        txtPortVRX.Name = "txtPortVRX"
        txtPortVRX.Size = New Size(191, 20)
        txtPortVRX.TabIndex = 38
        ' 
        ' txtExtras
        ' 
        txtExtras.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtExtras.BorderStyle = BorderStyle.FixedSingle
        txtExtras.ForeColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        txtExtras.Location = New Point(19, 281)
        txtExtras.Name = "txtExtras"
        txtExtras.Size = New Size(420, 20)
        txtExtras.TabIndex = 39
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TabPage5.Controls.Add(btnGenerateKeys)
        TabPage5.Controls.Add(btnSendKeys)
        TabPage5.Controls.Add(btnReceiveKeys)
        TabPage5.Controls.Add(btnUpdate)
        TabPage5.Location = New Point(4, 23)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(482, 340)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Setup"
        ' 
        ' btnGenerateKeys
        ' 
        btnGenerateKeys.BackColor = Color.Gold
        btnGenerateKeys.FlatStyle = FlatStyle.Popup
        btnGenerateKeys.Location = New Point(15, 53)
        btnGenerateKeys.Name = "btnGenerateKeys"
        btnGenerateKeys.Size = New Size(117, 30)
        btnGenerateKeys.TabIndex = 37
        btnGenerateKeys.Text = "Generate keys"
        btnToolTip.SetToolTip(btnGenerateKeys, "Generate gs.key and drone.key" & vbCrLf & "to the Ground Station and" & vbCrLf & "copy gs.key to /etc/")
        btnGenerateKeys.UseVisualStyleBackColor = False
        ' 
        ' btnSendKeys
        ' 
        btnSendKeys.BackColor = Color.Gold
        btnSendKeys.FlatStyle = FlatStyle.Popup
        btnSendKeys.Location = New Point(15, 126)
        btnSendKeys.Name = "btnSendKeys"
        btnSendKeys.Size = New Size(117, 30)
        btnSendKeys.TabIndex = 36
        btnSendKeys.Text = "Send drone.key"
        btnToolTip.SetToolTip(btnSendKeys, "Send drone.key to the designated IP")
        btnSendKeys.UseVisualStyleBackColor = False
        ' 
        ' btnReceiveKeys
        ' 
        btnReceiveKeys.BackColor = Color.Gold
        btnReceiveKeys.FlatStyle = FlatStyle.Popup
        btnReceiveKeys.Location = New Point(15, 89)
        btnReceiveKeys.Name = "btnReceiveKeys"
        btnReceiveKeys.Size = New Size(117, 30)
        btnReceiveKeys.TabIndex = 35
        btnReceiveKeys.Text = "Receive drone.key"
        btnToolTip.SetToolTip(btnReceiveKeys, "Receive drone.key from the designated IP")
        btnReceiveKeys.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Gold
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Location = New Point(15, 17)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(117, 30)
        btnUpdate.TabIndex = 34
        btnUpdate.Text = "Firmware Update"
        btnToolTip.SetToolTip(btnUpdate, "Update the firmware" & vbCrLf & "from the OpenIPC servers")
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnRead
        ' 
        btnRead.BackColor = Color.Gold
        btnRead.FlatStyle = FlatStyle.Popup
        btnRead.Font = New Font("Arial", 8.25F, FontStyle.Bold)
        btnRead.ForeColor = Color.Black
        btnRead.Location = New Point(76, 408)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(60, 30)
        btnRead.TabIndex = 23
        btnRead.Text = "2. Read"
        btnToolTip.SetToolTip(btnRead, "Read the settings from the local files" & vbCrLf & "that was previously received from the camera")
        btnRead.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(9, 386)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 24
        Label1.Text = "IP Address:"
        ' 
        ' btnReboot
        ' 
        btnReboot.BackColor = Color.Gold
        btnReboot.FlatStyle = FlatStyle.Popup
        btnReboot.Font = New Font("Arial", 8.25F, FontStyle.Bold)
        btnReboot.ForeColor = Color.Black
        btnReboot.Location = New Point(220, 408)
        btnReboot.Name = "btnReboot"
        btnReboot.Size = New Size(83, 30)
        btnReboot.TabIndex = 25
        btnReboot.Text = "5. Reboot"
        btnToolTip.SetToolTip(btnReboot, "Reboot the camera")
        btnReboot.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Arial", 9F, FontStyle.Bold)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(225, 383)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(78, 21)
        txtPassword.TabIndex = 31
        txtPassword.Text = "12345"
        btnToolTip.SetToolTip(txtPassword, "Type the OpenIPC Camera IP" & vbCrLf & "in a correct format XXX.XXX.XXX.XXX")
        ' 
        ' rBtnCam
        ' 
        rBtnCam.AutoSize = True
        rBtnCam.Checked = True
        rBtnCam.ForeColor = Color.White
        rBtnCam.Location = New Point(339, 382)
        rBtnCam.Name = "rBtnCam"
        rBtnCam.Size = New Size(116, 19)
        rBtnCam.TabIndex = 27
        rBtnCam.TabStop = True
        rBtnCam.Text = "OpenIPC Camera"
        rBtnCam.UseVisualStyleBackColor = True
        ' 
        ' rBtnNVR
        ' 
        rBtnNVR.AutoSize = True
        rBtnNVR.ForeColor = Color.White
        rBtnNVR.Location = New Point(339, 402)
        rBtnNVR.Name = "rBtnNVR"
        rBtnNVR.Size = New Size(87, 19)
        rBtnNVR.TabIndex = 28
        rBtnNVR.Text = "NVR Hi3536"
        rBtnNVR.UseVisualStyleBackColor = True
        ' 
        ' rBtnRadxaZero3w
        ' 
        rBtnRadxaZero3w.AutoSize = True
        rBtnRadxaZero3w.ForeColor = Color.White
        rBtnRadxaZero3w.Location = New Point(339, 422)
        rBtnRadxaZero3w.Name = "rBtnRadxaZero3w"
        rBtnRadxaZero3w.Size = New Size(156, 19)
        rBtnRadxaZero3w.TabIndex = 29
        rBtnRadxaZero3w.Text = "Radxa Zero 3w (WFB-ng)"
        rBtnRadxaZero3w.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(159, 386)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 30
        Label3.Text = "Password:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(512, 24)
        MenuStrip1.TabIndex = 32
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Visible = False
        ' 
        ' Configurator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        ClientSize = New Size(512, 450)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(rBtnRadxaZero3w)
        Controls.Add(rBtnNVR)
        Controls.Add(rBtnCam)
        Controls.Add(btnReboot)
        Controls.Add(Label1)
        Controls.Add(btnRead)
        Controls.Add(TabControl1)
        Controls.Add(btnSend)
        Controls.Add(txtIP)
        Controls.Add(btnGet)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Configurator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OpenIPC Configurator"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGet As Button
    Friend WithEvents txtIP As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtFrequency As TextBox
    Friend WithEvents txtResolution As TextBox
    Friend WithEvents txtFPS As TextBox
    Friend WithEvents txtEncode As TextBox
    Friend WithEvents txtBitrate As TextBox
    Friend WithEvents txtExposure As TextBox
    Friend WithEvents txtContrast As TextBox
    Friend WithEvents txtHue As TextBox
    Friend WithEvents txtSaturation As TextBox
    Friend WithEvents txtLuminance As TextBox
    Friend WithEvents txtPower As TextBox
    Friend WithEvents txtSensor As TextBox
    Friend WithEvents txtFreq24 As TextBox
    Friend WithEvents txtMCS As TextBox
    Friend WithEvents txtLDPC As TextBox
    Friend WithEvents txtSTBC As TextBox
    Friend WithEvents txtFECN As TextBox
    Friend WithEvents txtFECK As TextBox
    Friend WithEvents txtPower24 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtSaveFreq As Button
    Friend WithEvents txtSaveCam As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents cmbLuminance As ComboBox
    Friend WithEvents cmbSaturation As ComboBox
    Friend WithEvents cmbHue As ComboBox
    Friend WithEvents cmbContrast As ComboBox
    Friend WithEvents cmbExposure As ComboBox
    Friend WithEvents cmbBitrate As ComboBox
    Friend WithEvents cmbCodec As ComboBox
    Friend WithEvents cmbFPS As ComboBox
    Friend WithEvents cmbResolution As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnToolTip As ToolTip
    Friend WithEvents btnReboot As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cmbMCSTLM As ComboBox
    Friend WithEvents cmbRouter As ComboBox
    Friend WithEvents cmbBaud As ComboBox
    Friend WithEvents cmbSerial As ComboBox
    Friend WithEvents txtMCSTLM As TextBox
    Friend WithEvents txtRouter As TextBox
    Friend WithEvents txtBaud As TextBox
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents txtSaveTLM As Button
    Friend WithEvents btnUART2OFF As Button
    Friend WithEvents btnUART2 As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnGenerateKeys As Button
    Friend WithEvents btnSendKeys As Button
    Friend WithEvents btnReceiveKeys As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtSaveVRX As Button
    Friend WithEvents cmbOSD As ComboBox
    Friend WithEvents cmbCodecVRX As ComboBox
    Friend WithEvents cmbResolutionVRX As ComboBox
    Friend WithEvents txtResolutionVRX As TextBox
    Friend WithEvents txtMavlinkVRX As TextBox
    Friend WithEvents txtCodecVRX As TextBox
    Friend WithEvents txtOSD As TextBox
    Friend WithEvents txtPortVRX As TextBox
    Friend WithEvents txtExtras As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFormat As TextBox
    Friend WithEvents cmbFormat As ComboBox
    Friend WithEvents btnRestartWFB As Button
    Friend WithEvents btnRestartMajestic As Button
    Friend WithEvents rBtnCam As RadioButton
    Friend WithEvents rBtnNVR As RadioButton
    Friend WithEvents rBtnRadxaZero3w As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip

End Class
