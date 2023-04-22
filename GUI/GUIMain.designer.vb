﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUIMain
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUIMain))
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnPackageHourlyRate = New System.Windows.Forms.Button()
        Me.btnApplianceCalc = New System.Windows.Forms.Button()
        Me.btnExchangePriceComparison = New System.Windows.Forms.Button()
        Me.btnConsumptionHistory = New System.Windows.Forms.Button()
        Me.btnPackageComparison = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Main = New System.Windows.Forms.TabPage()
        Me.cbColor = New System.Windows.Forms.ComboBox()
        Me.chrtFrontPage = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabPackageHourlyRate = New System.Windows.Forms.TabPage()
        Me.btnChartAsc = New System.Windows.Forms.Button()
        Me.chrtPackageHourlyRate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tblPriceTable = New System.Windows.Forms.DataGridView()
        Me.tBoxPackageHourlyRate = New System.Windows.Forms.TextBox()
        Me.lblPriceGraph = New System.Windows.Forms.Label()
        Me.lblPriceTable = New System.Windows.Forms.Label()
        Me.lblPackageHourlyRate = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnConfirmInput = New System.Windows.Forms.Button()
        Me.tboxMonthlyCost = New System.Windows.Forms.TextBox()
        Me.lblMonthlyCost = New System.Windows.Forms.Label()
        Me.rdioFixedPrice = New System.Windows.Forms.RadioButton()
        Me.rdioExchange = New System.Windows.Forms.RadioButton()
        Me.lblPackageHourly = New System.Windows.Forms.Label()
        Me.btnBack0 = New System.Windows.Forms.Button()
        Me.tabApplianceCalc = New System.Windows.Forms.TabPage()
        Me.lblSKwh1 = New System.Windows.Forms.Label()
        Me.lblSKwh2 = New System.Windows.Forms.Label()
        Me.tBoxMarginal = New System.Windows.Forms.TextBox()
        Me.lblMore = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.radioStockPlusMore = New System.Windows.Forms.RadioButton()
        Me.rdioUniversalPackage = New System.Windows.Forms.RadioButton()
        Me.rdioFixedPrice1 = New System.Windows.Forms.RadioButton()
        Me.rdioExchangePrice = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTaasta = New System.Windows.Forms.Button()
        Me.btnSisesta = New System.Windows.Forms.Button()
        Me.lblCents = New System.Windows.Forms.Label()
        Me.lblKwh24h = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblWatt = New System.Windows.Forms.Label()
        Me.lblApplianceResult = New System.Windows.Forms.Label()
        Me.lblElectricityConsumptionRate = New System.Windows.Forms.Label()
        Me.tBoxUsageTime = New System.Windows.Forms.TextBox()
        Me.lblRoughPrice = New System.Windows.Forms.Label()
        Me.tBoxConsumptionPerHour = New System.Windows.Forms.TextBox()
        Me.tBoxElectricityConsumptionRate = New System.Windows.Forms.TextBox()
        Me.lblUsageTime = New System.Windows.Forms.Label()
        Me.tBoxApproxPrice = New System.Windows.Forms.TextBox()
        Me.lblConsumptionPerHour = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdioFridge = New System.Windows.Forms.RadioButton()
        Me.rdioCoffeeMaker = New System.Windows.Forms.RadioButton()
        Me.rdioToaster = New System.Windows.Forms.RadioButton()
        Me.rdioVacuum = New System.Windows.Forms.RadioButton()
        Me.rdioMixer = New System.Windows.Forms.RadioButton()
        Me.rdioMicrowave = New System.Windows.Forms.RadioButton()
        Me.rdioElecStove = New System.Windows.Forms.RadioButton()
        Me.rdioRouter = New System.Windows.Forms.RadioButton()
        Me.rdioFoodProcessor = New System.Windows.Forms.RadioButton()
        Me.rdioSewingMachine = New System.Windows.Forms.RadioButton()
        Me.rdioTV = New System.Windows.Forms.RadioButton()
        Me.rdioLED = New System.Windows.Forms.RadioButton()
        Me.rdioRadio = New System.Windows.Forms.RadioButton()
        Me.rdioPrinter = New System.Windows.Forms.RadioButton()
        Me.rdioEggCooker = New System.Windows.Forms.RadioButton()
        Me.rdioHairDryer = New System.Windows.Forms.RadioButton()
        Me.rdioComputer = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.tBoxPackagePrice = New System.Windows.Forms.TextBox()
        Me.lblCurrentPackagePrice = New System.Windows.Forms.Label()
        Me.lblOptional = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblApplianceChoice = New System.Windows.Forms.Label()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.tabExchangeComparison = New System.Windows.Forms.TabPage()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lblExchangeComparisonResult = New System.Windows.Forms.Label()
        Me.tBoxCondition2 = New System.Windows.Forms.TextBox()
        Me.tBoxCondition1 = New System.Windows.Forms.TextBox()
        Me.tBoxEndTime = New System.Windows.Forms.TextBox()
        Me.tboxStartTime = New System.Windows.Forms.TextBox()
        Me.lblExchangeChoice = New System.Windows.Forms.Label()
        Me.lblCase2 = New System.Windows.Forms.Label()
        Me.lblCase1 = New System.Windows.Forms.Label()
        Me.lblEnterPrice = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblTimePeriodSelection = New System.Windows.Forms.Label()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.tabConsumptionHistory = New System.Windows.Forms.TabPage()
        Me.btnSimulateConsumptionHistory = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tabBlank = New System.Windows.Forms.TabPage()
        Me.tabClientConsumptionHistory = New System.Windows.Forms.TabPage()
        Me.lblSimulateClientConsumptionHistory = New System.Windows.Forms.Label()
        Me.lblComparisonGraph = New System.Windows.Forms.Label()
        Me.lblConsumptionGraph = New System.Windows.Forms.Label()
        Me.lblClientConsumptionHistoryResult = New System.Windows.Forms.Label()
        Me.lblUploadComparisonPackageCSV = New System.Windows.Forms.Label()
        Me.lblUploadClientHistoryCSV = New System.Windows.Forms.Label()
        Me.lblHistoryData = New System.Windows.Forms.Label()
        Me.tabSimulateExchangeHistory = New System.Windows.Forms.TabPage()
        Me.lblExchangePackageHistory = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSeeHistory = New System.Windows.Forms.Button()
        Me.tBoxMonthlyCost2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClientConsumptionHistory = New System.Windows.Forms.Button()
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.tabPackageComparison = New System.Windows.Forms.TabPage()
        Me.btnPackets = New System.Windows.Forms.Button()
        Me.chartPackages = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.lblComparisonResult = New System.Windows.Forms.Label()
        Me.cBoxPackage2 = New System.Windows.Forms.ComboBox()
        Me.cBoxPackage1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPackage1 = New System.Windows.Forms.Label()
        Me.lblChoosePackages = New System.Windows.Forms.Label()
        Me.btnBack4 = New System.Windows.Forms.Button()
        Me.lblChangeFontSize = New System.Windows.Forms.Label()
        Me.btnFontIncrease = New System.Windows.Forms.Button()
        Me.btnFontDecrease = New System.Windows.Forms.Button()
        Me.btnRestoreFontSize = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.Main.SuspendLayout()
        CType(Me.chrtFrontPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPackageHourlyRate.SuspendLayout()
        CType(Me.chrtPackageHourlyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblPriceTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabApplianceCalc.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabExchangeComparison.SuspendLayout()
        Me.tabConsumptionHistory.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabClientConsumptionHistory.SuspendLayout()
        Me.tabSimulateExchangeHistory.SuspendLayout()
        Me.tabPackageComparison.SuspendLayout()
        CType(Me.chartPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Location = New System.Drawing.Point(13, 13)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(47, 13)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "MENÜÜ"
        '
        'btnPackageHourlyRate
        '
        Me.btnPackageHourlyRate.Location = New System.Drawing.Point(17, 21)
        Me.btnPackageHourlyRate.Name = "btnPackageHourlyRate"
        Me.btnPackageHourlyRate.Size = New System.Drawing.Size(168, 92)
        Me.btnPackageHourlyRate.TabIndex = 1
        Me.btnPackageHourlyRate.Text = "Kuva paketijärgne tunnihind"
        Me.btnPackageHourlyRate.UseVisualStyleBackColor = True
        '
        'btnApplianceCalc
        '
        Me.btnApplianceCalc.Location = New System.Drawing.Point(191, 21)
        Me.btnApplianceCalc.Name = "btnApplianceCalc"
        Me.btnApplianceCalc.Size = New System.Drawing.Size(168, 92)
        Me.btnApplianceCalc.TabIndex = 2
        Me.btnApplianceCalc.Text = "Kodumasina tarbimise hinna kalkulaator"
        Me.btnApplianceCalc.UseVisualStyleBackColor = True
        '
        'btnExchangePriceComparison
        '
        Me.btnExchangePriceComparison.Location = New System.Drawing.Point(365, 21)
        Me.btnExchangePriceComparison.Name = "btnExchangePriceComparison"
        Me.btnExchangePriceComparison.Size = New System.Drawing.Size(168, 92)
        Me.btnExchangePriceComparison.TabIndex = 3
        Me.btnExchangePriceComparison.Text = "Börsihinna võrdlus elektriteenuse pakkujatega"
        Me.btnExchangePriceComparison.UseVisualStyleBackColor = True
        '
        'btnConsumptionHistory
        '
        Me.btnConsumptionHistory.Location = New System.Drawing.Point(17, 119)
        Me.btnConsumptionHistory.Name = "btnConsumptionHistory"
        Me.btnConsumptionHistory.Size = New System.Drawing.Size(168, 92)
        Me.btnConsumptionHistory.TabIndex = 4
        Me.btnConsumptionHistory.Text = "Vaata oma tarbimise ajalugu"
        Me.btnConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnPackageComparison
        '
        Me.btnPackageComparison.Location = New System.Drawing.Point(191, 119)
        Me.btnPackageComparison.Name = "btnPackageComparison"
        Me.btnPackageComparison.Size = New System.Drawing.Size(168, 92)
        Me.btnPackageComparison.TabIndex = 5
        Me.btnPackageComparison.Text = "Võrdle elektripakette"
        Me.btnPackageComparison.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.Main)
        Me.TabControl1.Controls.Add(Me.tabPackageHourlyRate)
        Me.TabControl1.Controls.Add(Me.tabApplianceCalc)
        Me.TabControl1.Controls.Add(Me.tabExchangeComparison)
        Me.TabControl1.Controls.Add(Me.tabConsumptionHistory)
        Me.TabControl1.Controls.Add(Me.tabPackageComparison)
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 22)
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(946, 649)
        Me.TabControl1.TabIndex = 6
        '
        'Main
        '
        Me.Main.BackColor = System.Drawing.Color.Transparent
        Me.Main.Controls.Add(Me.cbColor)
        Me.Main.Controls.Add(Me.chrtFrontPage)
        Me.Main.Controls.Add(Me.btnPackageHourlyRate)
        Me.Main.Controls.Add(Me.btnPackageComparison)
        Me.Main.Controls.Add(Me.btnApplianceCalc)
        Me.Main.Controls.Add(Me.btnConsumptionHistory)
        Me.Main.Controls.Add(Me.btnExchangePriceComparison)
        Me.Main.Location = New System.Drawing.Point(4, 26)
        Me.Main.Name = "Main"
        Me.Main.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Main.Size = New System.Drawing.Size(856, 597)
        Me.Main.TabIndex = 0
        Me.Main.Text = "Home"
        '
        'cbColor
        '
        Me.cbColor.AllowDrop = True
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Items.AddRange(New Object() {"Punane", "Sinine", "Roheline", "Roosa", "Valge", "Tumehall", "Helehall"})
        Me.cbColor.Location = New System.Drawing.Point(661, 46)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.Size = New System.Drawing.Size(121, 21)
        Me.cbColor.TabIndex = 9
        Me.cbColor.Text = "Vali värv"
        '
        'chrtFrontPage
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrtFrontPage.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtFrontPage.Legends.Add(Legend1)
        Me.chrtFrontPage.Location = New System.Drawing.Point(17, 242)
        Me.chrtFrontPage.Name = "chrtFrontPage"
        Me.chrtFrontPage.Size = New System.Drawing.Size(765, 338)
        Me.chrtFrontPage.TabIndex = 8
        Me.chrtFrontPage.Text = "Chart2"
        '
        'tabPackageHourlyRate
        '
        Me.tabPackageHourlyRate.Controls.Add(Me.btnChartAsc)
        Me.tabPackageHourlyRate.Controls.Add(Me.chrtPackageHourlyRate)
        Me.tabPackageHourlyRate.Controls.Add(Me.tblPriceTable)
        Me.tabPackageHourlyRate.Controls.Add(Me.tBoxPackageHourlyRate)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblPriceGraph)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblPriceTable)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblPackageHourlyRate)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblResult)
        Me.tabPackageHourlyRate.Controls.Add(Me.btnConfirmInput)
        Me.tabPackageHourlyRate.Controls.Add(Me.tboxMonthlyCost)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblMonthlyCost)
        Me.tabPackageHourlyRate.Controls.Add(Me.rdioFixedPrice)
        Me.tabPackageHourlyRate.Controls.Add(Me.rdioExchange)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblPackageHourly)
        Me.tabPackageHourlyRate.Controls.Add(Me.btnBack0)
        Me.tabPackageHourlyRate.Location = New System.Drawing.Point(4, 26)
        Me.tabPackageHourlyRate.Name = "tabPackageHourlyRate"
        Me.tabPackageHourlyRate.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabPackageHourlyRate.Size = New System.Drawing.Size(912, 618)
        Me.tabPackageHourlyRate.TabIndex = 1
        Me.tabPackageHourlyRate.Text = "Paketijärgne tunnihind"
        Me.tabPackageHourlyRate.UseVisualStyleBackColor = True
        '
        'btnChartAsc
        '
        Me.btnChartAsc.Location = New System.Drawing.Point(26, 242)
        Me.btnChartAsc.Name = "btnChartAsc"
        Me.btnChartAsc.Size = New System.Drawing.Size(146, 32)
        Me.btnChartAsc.TabIndex = 15
        Me.btnChartAsc.Text = "Järjesta tabel kasvavalt"
        Me.btnChartAsc.UseVisualStyleBackColor = True
        '
        'chrtPackageHourlyRate
        '
        ChartArea2.Name = "ChartArea1"
        Me.chrtPackageHourlyRate.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chrtPackageHourlyRate.Legends.Add(Legend2)
        Me.chrtPackageHourlyRate.Location = New System.Drawing.Point(327, 186)
        Me.chrtPackageHourlyRate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chrtPackageHourlyRate.Name = "chrtPackageHourlyRate"
        Me.chrtPackageHourlyRate.Size = New System.Drawing.Size(472, 374)
        Me.chrtPackageHourlyRate.TabIndex = 14
        Me.chrtPackageHourlyRate.Text = "Chart1"
        '
        'tblPriceTable
        '
        Me.tblPriceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPriceTable.Location = New System.Drawing.Point(26, 333)
        Me.tblPriceTable.Name = "tblPriceTable"
        Me.tblPriceTable.ReadOnly = True
        Me.tblPriceTable.RowHeadersWidth = 51
        Me.tblPriceTable.Size = New System.Drawing.Size(240, 150)
        Me.tblPriceTable.TabIndex = 13
        '
        'tBoxPackageHourlyRate
        '
        Me.tBoxPackageHourlyRate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tBoxPackageHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxPackageHourlyRate.Cursor = System.Windows.Forms.Cursors.No
        Me.tBoxPackageHourlyRate.Enabled = False
        Me.tBoxPackageHourlyRate.ForeColor = System.Drawing.SystemColors.MenuText
        Me.tBoxPackageHourlyRate.Location = New System.Drawing.Point(665, 123)
        Me.tBoxPackageHourlyRate.Name = "tBoxPackageHourlyRate"
        Me.tBoxPackageHourlyRate.ReadOnly = True
        Me.tBoxPackageHourlyRate.Size = New System.Drawing.Size(100, 20)
        Me.tBoxPackageHourlyRate.TabIndex = 11
        '
        'lblPriceGraph
        '
        Me.lblPriceGraph.AutoSize = True
        Me.lblPriceGraph.Location = New System.Drawing.Point(324, 148)
        Me.lblPriceGraph.Name = "lblPriceGraph"
        Me.lblPriceGraph.Size = New System.Drawing.Size(70, 13)
        Me.lblPriceGraph.TabIndex = 10
        Me.lblPriceGraph.Text = "Hinnagraafik:"
        '
        'lblPriceTable
        '
        Me.lblPriceTable.AutoSize = True
        Me.lblPriceTable.Location = New System.Drawing.Point(23, 306)
        Me.lblPriceTable.Name = "lblPriceTable"
        Me.lblPriceTable.Size = New System.Drawing.Size(61, 13)
        Me.lblPriceTable.TabIndex = 9
        Me.lblPriceTable.Text = "Hinnatabel:"
        '
        'lblPackageHourlyRate
        '
        Me.lblPackageHourlyRate.AutoSize = True
        Me.lblPackageHourlyRate.Location = New System.Drawing.Point(499, 126)
        Me.lblPackageHourlyRate.Name = "lblPackageHourlyRate"
        Me.lblPackageHourlyRate.Size = New System.Drawing.Size(115, 13)
        Me.lblPackageHourlyRate.TabIndex = 8
        Me.lblPackageHourlyRate.Text = "Paketijärgne tunnihind:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(499, 74)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(50, 13)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Tulemus:"
        '
        'btnConfirmInput
        '
        Me.btnConfirmInput.Location = New System.Drawing.Point(197, 186)
        Me.btnConfirmInput.Name = "btnConfirmInput"
        Me.btnConfirmInput.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmInput.TabIndex = 6
        Me.btnConfirmInput.Text = "Kinnita andmed"
        Me.btnConfirmInput.UseVisualStyleBackColor = True
        '
        'tboxMonthlyCost
        '
        Me.tboxMonthlyCost.Location = New System.Drawing.Point(129, 141)
        Me.tboxMonthlyCost.Name = "tboxMonthlyCost"
        Me.tboxMonthlyCost.Size = New System.Drawing.Size(100, 20)
        Me.tboxMonthlyCost.TabIndex = 5
        '
        'lblMonthlyCost
        '
        Me.lblMonthlyCost.AutoSize = True
        Me.lblMonthlyCost.Location = New System.Drawing.Point(53, 144)
        Me.lblMonthlyCost.Name = "lblMonthlyCost"
        Me.lblMonthlyCost.Size = New System.Drawing.Size(46, 13)
        Me.lblMonthlyCost.TabIndex = 4
        Me.lblMonthlyCost.Text = "Kuutasu"
        '
        'rdioFixedPrice
        '
        Me.rdioFixedPrice.AutoSize = True
        Me.rdioFixedPrice.Location = New System.Drawing.Point(190, 87)
        Me.rdioFixedPrice.Name = "rdioFixedPrice"
        Me.rdioFixedPrice.Size = New System.Drawing.Size(99, 17)
        Me.rdioFixedPrice.TabIndex = 3
        Me.rdioFixedPrice.TabStop = True
        Me.rdioFixedPrice.Text = "Fikseeritud hind"
        Me.rdioFixedPrice.UseVisualStyleBackColor = True
        '
        'rdioExchange
        '
        Me.rdioExchange.AutoSize = True
        Me.rdioExchange.Location = New System.Drawing.Point(36, 87)
        Me.rdioExchange.Name = "rdioExchange"
        Me.rdioExchange.Size = New System.Drawing.Size(68, 17)
        Me.rdioExchange.TabIndex = 2
        Me.rdioExchange.TabStop = True
        Me.rdioExchange.Text = "Börsihind"
        Me.rdioExchange.UseVisualStyleBackColor = True
        '
        'lblPackageHourly
        '
        Me.lblPackageHourly.AutoSize = True
        Me.lblPackageHourly.Location = New System.Drawing.Point(110, 22)
        Me.lblPackageHourly.Name = "lblPackageHourly"
        Me.lblPackageHourly.Size = New System.Drawing.Size(162, 13)
        Me.lblPackageHourly.TabIndex = 1
        Me.lblPackageHourly.Text = "Kehtiva paketi andmete sisestus:"
        '
        'btnBack0
        '
        Me.btnBack0.Location = New System.Drawing.Point(16, 12)
        Me.btnBack0.Name = "btnBack0"
        Me.btnBack0.Size = New System.Drawing.Size(83, 33)
        Me.btnBack0.TabIndex = 0
        Me.btnBack0.Text = "Tagasi"
        Me.btnBack0.UseVisualStyleBackColor = True
        '
        'tabApplianceCalc
        '
        Me.tabApplianceCalc.Controls.Add(Me.lblSKwh1)
        Me.tabApplianceCalc.Controls.Add(Me.lblSKwh2)
        Me.tabApplianceCalc.Controls.Add(Me.tBoxMarginal)
        Me.tabApplianceCalc.Controls.Add(Me.lblMore)
        Me.tabApplianceCalc.Controls.Add(Me.Panel3)
        Me.tabApplianceCalc.Controls.Add(Me.Panel2)
        Me.tabApplianceCalc.Controls.Add(Me.Panel1)
        Me.tabApplianceCalc.Controls.Add(Me.btnConfirm)
        Me.tabApplianceCalc.Controls.Add(Me.tBoxPackagePrice)
        Me.tabApplianceCalc.Controls.Add(Me.lblCurrentPackagePrice)
        Me.tabApplianceCalc.Controls.Add(Me.lblOptional)
        Me.tabApplianceCalc.Controls.Add(Me.Label3)
        Me.tabApplianceCalc.Controls.Add(Me.lblApplianceChoice)
        Me.tabApplianceCalc.Controls.Add(Me.btnBack1)
        Me.tabApplianceCalc.Location = New System.Drawing.Point(4, 26)
        Me.tabApplianceCalc.Name = "tabApplianceCalc"
        Me.tabApplianceCalc.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabApplianceCalc.Size = New System.Drawing.Size(938, 619)
        Me.tabApplianceCalc.TabIndex = 2
        Me.tabApplianceCalc.Text = "Kodumasina tarbimise hinna kalkulaator"
        Me.tabApplianceCalc.UseVisualStyleBackColor = True
        '
        'lblSKwh1
        '
        Me.lblSKwh1.AutoSize = True
        Me.lblSKwh1.Location = New System.Drawing.Point(311, 497)
        Me.lblSKwh1.Name = "lblSKwh1"
        Me.lblSKwh1.Size = New System.Drawing.Size(40, 13)
        Me.lblSKwh1.TabIndex = 46
        Me.lblSKwh1.Text = "s/kWh"
        '
        'lblSKwh2
        '
        Me.lblSKwh2.AutoSize = True
        Me.lblSKwh2.Location = New System.Drawing.Point(311, 537)
        Me.lblSKwh2.Name = "lblSKwh2"
        Me.lblSKwh2.Size = New System.Drawing.Size(40, 13)
        Me.lblSKwh2.TabIndex = 45
        Me.lblSKwh2.Text = "s/kWh"
        '
        'tBoxMarginal
        '
        Me.tBoxMarginal.Location = New System.Drawing.Point(205, 533)
        Me.tBoxMarginal.Name = "tBoxMarginal"
        Me.tBoxMarginal.Size = New System.Drawing.Size(100, 20)
        Me.tBoxMarginal.TabIndex = 43
        '
        'lblMore
        '
        Me.lblMore.AutoSize = True
        Me.lblMore.Location = New System.Drawing.Point(39, 533)
        Me.lblMore.Name = "lblMore"
        Me.lblMore.Size = New System.Drawing.Size(92, 13)
        Me.lblMore.TabIndex = 42
        Me.lblMore.Text = "Sisesta marginaal:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.radioStockPlusMore)
        Me.Panel3.Controls.Add(Me.rdioUniversalPackage)
        Me.Panel3.Controls.Add(Me.rdioFixedPrice1)
        Me.Panel3.Controls.Add(Me.rdioExchangePrice)
        Me.Panel3.Location = New System.Drawing.Point(36, 409)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(338, 82)
        Me.Panel3.TabIndex = 41
        '
        'radioStockPlusMore
        '
        Me.radioStockPlusMore.AutoSize = True
        Me.radioStockPlusMore.Location = New System.Drawing.Point(159, 3)
        Me.radioStockPlusMore.Name = "radioStockPlusMore"
        Me.radioStockPlusMore.Size = New System.Drawing.Size(125, 17)
        Me.radioStockPlusMore.TabIndex = 43
        Me.radioStockPlusMore.TabStop = True
        Me.radioStockPlusMore.Text = "Börsihind + marginaal"
        Me.radioStockPlusMore.UseVisualStyleBackColor = True
        '
        'rdioUniversalPackage
        '
        Me.rdioUniversalPackage.AutoSize = True
        Me.rdioUniversalPackage.Location = New System.Drawing.Point(25, 49)
        Me.rdioUniversalPackage.Name = "rdioUniversalPackage"
        Me.rdioUniversalPackage.Size = New System.Drawing.Size(108, 17)
        Me.rdioUniversalPackage.TabIndex = 42
        Me.rdioUniversalPackage.TabStop = True
        Me.rdioUniversalPackage.Text = "Universaal pakett"
        Me.rdioUniversalPackage.UseVisualStyleBackColor = True
        '
        'rdioFixedPrice1
        '
        Me.rdioFixedPrice1.AutoSize = True
        Me.rdioFixedPrice1.Location = New System.Drawing.Point(25, 26)
        Me.rdioFixedPrice1.Name = "rdioFixedPrice1"
        Me.rdioFixedPrice1.Size = New System.Drawing.Size(99, 17)
        Me.rdioFixedPrice1.TabIndex = 12
        Me.rdioFixedPrice1.TabStop = True
        Me.rdioFixedPrice1.Text = "Fikseeritud hind"
        Me.rdioFixedPrice1.UseVisualStyleBackColor = True
        '
        'rdioExchangePrice
        '
        Me.rdioExchangePrice.AutoSize = True
        Me.rdioExchangePrice.Location = New System.Drawing.Point(25, 3)
        Me.rdioExchangePrice.Name = "rdioExchangePrice"
        Me.rdioExchangePrice.Size = New System.Drawing.Size(68, 17)
        Me.rdioExchangePrice.TabIndex = 11
        Me.rdioExchangePrice.TabStop = True
        Me.rdioExchangePrice.Text = "Börsihind"
        Me.rdioExchangePrice.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnTaasta)
        Me.Panel2.Controls.Add(Me.btnSisesta)
        Me.Panel2.Controls.Add(Me.lblCents)
        Me.Panel2.Controls.Add(Me.lblKwh24h)
        Me.Panel2.Controls.Add(Me.lblMin)
        Me.Panel2.Controls.Add(Me.lblWatt)
        Me.Panel2.Controls.Add(Me.lblApplianceResult)
        Me.Panel2.Controls.Add(Me.lblElectricityConsumptionRate)
        Me.Panel2.Controls.Add(Me.tBoxUsageTime)
        Me.Panel2.Controls.Add(Me.lblRoughPrice)
        Me.Panel2.Controls.Add(Me.tBoxConsumptionPerHour)
        Me.Panel2.Controls.Add(Me.tBoxElectricityConsumptionRate)
        Me.Panel2.Controls.Add(Me.lblUsageTime)
        Me.Panel2.Controls.Add(Me.tBoxApproxPrice)
        Me.Panel2.Controls.Add(Me.lblConsumptionPerHour)
        Me.Panel2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Panel2.Location = New System.Drawing.Point(409, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(523, 275)
        Me.Panel2.TabIndex = 40
        '
        'btnTaasta
        '
        Me.btnTaasta.Location = New System.Drawing.Point(353, 11)
        Me.btnTaasta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTaasta.Name = "btnTaasta"
        Me.btnTaasta.Size = New System.Drawing.Size(67, 32)
        Me.btnTaasta.TabIndex = 44
        Me.btnTaasta.Text = "Taasta"
        Me.btnTaasta.UseVisualStyleBackColor = True
        '
        'btnSisesta
        '
        Me.btnSisesta.Location = New System.Drawing.Point(273, 11)
        Me.btnSisesta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSisesta.Name = "btnSisesta"
        Me.btnSisesta.Size = New System.Drawing.Size(67, 32)
        Me.btnSisesta.TabIndex = 43
        Me.btnSisesta.Text = "Sisesta"
        Me.btnSisesta.UseVisualStyleBackColor = True
        '
        'lblCents
        '
        Me.lblCents.AutoSize = True
        Me.lblCents.Location = New System.Drawing.Point(380, 171)
        Me.lblCents.Name = "lblCents"
        Me.lblCents.Size = New System.Drawing.Size(32, 13)
        Me.lblCents.TabIndex = 42
        Me.lblCents.Text = "senti "
        '
        'lblKwh24h
        '
        Me.lblKwh24h.AutoSize = True
        Me.lblKwh24h.Location = New System.Drawing.Point(380, 139)
        Me.lblKwh24h.Name = "lblKwh24h"
        Me.lblKwh24h.Size = New System.Drawing.Size(51, 13)
        Me.lblKwh24h.TabIndex = 41
        Me.lblKwh24h.Text = "kWh 24h"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(380, 85)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(23, 13)
        Me.lblMin.TabIndex = 40
        Me.lblMin.Text = "min"
        '
        'lblWatt
        '
        Me.lblWatt.AutoSize = True
        Me.lblWatt.Location = New System.Drawing.Point(380, 53)
        Me.lblWatt.Name = "lblWatt"
        Me.lblWatt.Size = New System.Drawing.Size(18, 13)
        Me.lblWatt.TabIndex = 39
        Me.lblWatt.Text = "W"
        '
        'lblApplianceResult
        '
        Me.lblApplianceResult.AutoSize = True
        Me.lblApplianceResult.Location = New System.Drawing.Point(17, 23)
        Me.lblApplianceResult.Name = "lblApplianceResult"
        Me.lblApplianceResult.Size = New System.Drawing.Size(50, 13)
        Me.lblApplianceResult.TabIndex = 5
        Me.lblApplianceResult.Text = "Tulemus:"
        '
        'lblElectricityConsumptionRate
        '
        Me.lblElectricityConsumptionRate.AutoSize = True
        Me.lblElectricityConsumptionRate.Location = New System.Drawing.Point(16, 138)
        Me.lblElectricityConsumptionRate.Name = "lblElectricityConsumptionRate"
        Me.lblElectricityConsumptionRate.Size = New System.Drawing.Size(150, 13)
        Me.lblElectricityConsumptionRate.TabIndex = 7
        Me.lblElectricityConsumptionRate.Text = "Elektrienergia tarbimise kogus:"
        '
        'tBoxUsageTime
        '
        Me.tBoxUsageTime.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tBoxUsageTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxUsageTime.HideSelection = False
        Me.tBoxUsageTime.Location = New System.Drawing.Point(274, 83)
        Me.tBoxUsageTime.Name = "tBoxUsageTime"
        Me.tBoxUsageTime.ReadOnly = True
        Me.tBoxUsageTime.Size = New System.Drawing.Size(100, 20)
        Me.tBoxUsageTime.TabIndex = 38
        '
        'lblRoughPrice
        '
        Me.lblRoughPrice.AutoSize = True
        Me.lblRoughPrice.Location = New System.Drawing.Point(16, 170)
        Me.lblRoughPrice.Name = "lblRoughPrice"
        Me.lblRoughPrice.Size = New System.Drawing.Size(88, 13)
        Me.lblRoughPrice.TabIndex = 8
        Me.lblRoughPrice.Text = "Orienteeruv hind:"
        '
        'tBoxConsumptionPerHour
        '
        Me.tBoxConsumptionPerHour.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tBoxConsumptionPerHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxConsumptionPerHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxConsumptionPerHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tBoxConsumptionPerHour.HideSelection = False
        Me.tBoxConsumptionPerHour.Location = New System.Drawing.Point(274, 51)
        Me.tBoxConsumptionPerHour.Name = "tBoxConsumptionPerHour"
        Me.tBoxConsumptionPerHour.ReadOnly = True
        Me.tBoxConsumptionPerHour.Size = New System.Drawing.Size(100, 20)
        Me.tBoxConsumptionPerHour.TabIndex = 37
        '
        'tBoxElectricityConsumptionRate
        '
        Me.tBoxElectricityConsumptionRate.BackColor = System.Drawing.Color.White
        Me.tBoxElectricityConsumptionRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxElectricityConsumptionRate.Enabled = False
        Me.tBoxElectricityConsumptionRate.ForeColor = System.Drawing.Color.Black
        Me.tBoxElectricityConsumptionRate.Location = New System.Drawing.Point(274, 136)
        Me.tBoxElectricityConsumptionRate.Name = "tBoxElectricityConsumptionRate"
        Me.tBoxElectricityConsumptionRate.ReadOnly = True
        Me.tBoxElectricityConsumptionRate.Size = New System.Drawing.Size(100, 20)
        Me.tBoxElectricityConsumptionRate.TabIndex = 16
        '
        'lblUsageTime
        '
        Me.lblUsageTime.AutoSize = True
        Me.lblUsageTime.Location = New System.Drawing.Point(16, 89)
        Me.lblUsageTime.Name = "lblUsageTime"
        Me.lblUsageTime.Size = New System.Drawing.Size(63, 13)
        Me.lblUsageTime.TabIndex = 36
        Me.lblUsageTime.Text = "Kasutusaeg"
        '
        'tBoxApproxPrice
        '
        Me.tBoxApproxPrice.BackColor = System.Drawing.Color.White
        Me.tBoxApproxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxApproxPrice.Enabled = False
        Me.tBoxApproxPrice.ForeColor = System.Drawing.Color.Black
        Me.tBoxApproxPrice.Location = New System.Drawing.Point(274, 168)
        Me.tBoxApproxPrice.Name = "tBoxApproxPrice"
        Me.tBoxApproxPrice.ReadOnly = True
        Me.tBoxApproxPrice.Size = New System.Drawing.Size(100, 20)
        Me.tBoxApproxPrice.TabIndex = 17
        '
        'lblConsumptionPerHour
        '
        Me.lblConsumptionPerHour.AutoSize = True
        Me.lblConsumptionPerHour.Location = New System.Drawing.Point(17, 57)
        Me.lblConsumptionPerHour.Name = "lblConsumptionPerHour"
        Me.lblConsumptionPerHour.Size = New System.Drawing.Size(100, 13)
        Me.lblConsumptionPerHour.TabIndex = 35
        Me.lblConsumptionPerHour.Text = "Energia kulu tunnis:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdioFridge)
        Me.Panel1.Controls.Add(Me.rdioCoffeeMaker)
        Me.Panel1.Controls.Add(Me.rdioToaster)
        Me.Panel1.Controls.Add(Me.rdioVacuum)
        Me.Panel1.Controls.Add(Me.rdioMixer)
        Me.Panel1.Controls.Add(Me.rdioMicrowave)
        Me.Panel1.Controls.Add(Me.rdioElecStove)
        Me.Panel1.Controls.Add(Me.rdioRouter)
        Me.Panel1.Controls.Add(Me.rdioFoodProcessor)
        Me.Panel1.Controls.Add(Me.rdioSewingMachine)
        Me.Panel1.Controls.Add(Me.rdioTV)
        Me.Panel1.Controls.Add(Me.rdioLED)
        Me.Panel1.Controls.Add(Me.rdioRadio)
        Me.Panel1.Controls.Add(Me.rdioPrinter)
        Me.Panel1.Controls.Add(Me.rdioEggCooker)
        Me.Panel1.Controls.Add(Me.rdioHairDryer)
        Me.Panel1.Controls.Add(Me.rdioComputer)
        Me.Panel1.Location = New System.Drawing.Point(36, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 275)
        Me.Panel1.TabIndex = 39
        '
        'rdioFridge
        '
        Me.rdioFridge.AutoSize = True
        Me.rdioFridge.Location = New System.Drawing.Point(183, 26)
        Me.rdioFridge.Name = "rdioFridge"
        Me.rdioFridge.Size = New System.Drawing.Size(72, 17)
        Me.rdioFridge.TabIndex = 27
        Me.rdioFridge.TabStop = True
        Me.rdioFridge.Text = "Külmkapp"
        Me.rdioFridge.UseVisualStyleBackColor = True
        '
        'rdioCoffeeMaker
        '
        Me.rdioCoffeeMaker.AutoSize = True
        Me.rdioCoffeeMaker.Location = New System.Drawing.Point(25, 26)
        Me.rdioCoffeeMaker.Name = "rdioCoffeeMaker"
        Me.rdioCoffeeMaker.Size = New System.Drawing.Size(79, 17)
        Me.rdioCoffeeMaker.TabIndex = 18
        Me.rdioCoffeeMaker.TabStop = True
        Me.rdioCoffeeMaker.Text = "Kohvimasin"
        Me.rdioCoffeeMaker.UseVisualStyleBackColor = True
        '
        'rdioToaster
        '
        Me.rdioToaster.AutoSize = True
        Me.rdioToaster.Location = New System.Drawing.Point(25, 49)
        Me.rdioToaster.Name = "rdioToaster"
        Me.rdioToaster.Size = New System.Drawing.Size(56, 17)
        Me.rdioToaster.TabIndex = 19
        Me.rdioToaster.TabStop = True
        Me.rdioToaster.Text = "Röster"
        Me.rdioToaster.UseVisualStyleBackColor = True
        '
        'rdioVacuum
        '
        Me.rdioVacuum.AutoSize = True
        Me.rdioVacuum.Location = New System.Drawing.Point(25, 72)
        Me.rdioVacuum.Name = "rdioVacuum"
        Me.rdioVacuum.Size = New System.Drawing.Size(78, 17)
        Me.rdioVacuum.TabIndex = 20
        Me.rdioVacuum.TabStop = True
        Me.rdioVacuum.Text = "Tolmuimeja"
        Me.rdioVacuum.UseVisualStyleBackColor = True
        '
        'rdioMixer
        '
        Me.rdioMixer.AutoSize = True
        Me.rdioMixer.Location = New System.Drawing.Point(25, 95)
        Me.rdioMixer.Name = "rdioMixer"
        Me.rdioMixer.Size = New System.Drawing.Size(56, 17)
        Me.rdioMixer.TabIndex = 21
        Me.rdioMixer.TabStop = True
        Me.rdioMixer.Text = "Mikser"
        Me.rdioMixer.UseVisualStyleBackColor = True
        '
        'rdioMicrowave
        '
        Me.rdioMicrowave.AutoSize = True
        Me.rdioMicrowave.Location = New System.Drawing.Point(183, 187)
        Me.rdioMicrowave.Name = "rdioMicrowave"
        Me.rdioMicrowave.Size = New System.Drawing.Size(87, 17)
        Me.rdioMicrowave.TabIndex = 34
        Me.rdioMicrowave.TabStop = True
        Me.rdioMicrowave.Text = "Mikrolaineahi"
        Me.rdioMicrowave.UseVisualStyleBackColor = True
        '
        'rdioElecStove
        '
        Me.rdioElecStove.AutoSize = True
        Me.rdioElecStove.Location = New System.Drawing.Point(25, 118)
        Me.rdioElecStove.Name = "rdioElecStove"
        Me.rdioElecStove.Size = New System.Drawing.Size(69, 17)
        Me.rdioElecStove.TabIndex = 22
        Me.rdioElecStove.TabStop = True
        Me.rdioElecStove.Text = "Elektripliit"
        Me.rdioElecStove.UseVisualStyleBackColor = True
        '
        'rdioRouter
        '
        Me.rdioRouter.AutoSize = True
        Me.rdioRouter.Location = New System.Drawing.Point(183, 164)
        Me.rdioRouter.Name = "rdioRouter"
        Me.rdioRouter.Size = New System.Drawing.Size(57, 17)
        Me.rdioRouter.TabIndex = 33
        Me.rdioRouter.TabStop = True
        Me.rdioRouter.Text = "Ruuter"
        Me.rdioRouter.UseVisualStyleBackColor = True
        '
        'rdioFoodProcessor
        '
        Me.rdioFoodProcessor.AutoSize = True
        Me.rdioFoodProcessor.Location = New System.Drawing.Point(25, 141)
        Me.rdioFoodProcessor.Name = "rdioFoodProcessor"
        Me.rdioFoodProcessor.Size = New System.Drawing.Size(92, 17)
        Me.rdioFoodProcessor.TabIndex = 23
        Me.rdioFoodProcessor.TabStop = True
        Me.rdioFoodProcessor.Text = "Köögikombain"
        Me.rdioFoodProcessor.UseVisualStyleBackColor = True
        '
        'rdioSewingMachine
        '
        Me.rdioSewingMachine.AutoSize = True
        Me.rdioSewingMachine.Location = New System.Drawing.Point(183, 141)
        Me.rdioSewingMachine.Name = "rdioSewingMachine"
        Me.rdioSewingMachine.Size = New System.Drawing.Size(87, 17)
        Me.rdioSewingMachine.TabIndex = 32
        Me.rdioSewingMachine.TabStop = True
        Me.rdioSewingMachine.Text = "Õmblusmasin"
        Me.rdioSewingMachine.UseVisualStyleBackColor = True
        '
        'rdioTV
        '
        Me.rdioTV.AutoSize = True
        Me.rdioTV.Location = New System.Drawing.Point(25, 164)
        Me.rdioTV.Name = "rdioTV"
        Me.rdioTV.Size = New System.Drawing.Size(39, 17)
        Me.rdioTV.TabIndex = 24
        Me.rdioTV.TabStop = True
        Me.rdioTV.Text = "TV"
        Me.rdioTV.UseVisualStyleBackColor = True
        '
        'rdioLED
        '
        Me.rdioLED.AutoSize = True
        Me.rdioLED.Location = New System.Drawing.Point(183, 118)
        Me.rdioLED.Name = "rdioLED"
        Me.rdioLED.Size = New System.Drawing.Size(100, 17)
        Me.rdioLED.TabIndex = 31
        Me.rdioLED.TabStop = True
        Me.rdioLED.Text = "Lambipirn (LED)"
        Me.rdioLED.UseVisualStyleBackColor = True
        '
        'rdioRadio
        '
        Me.rdioRadio.AutoSize = True
        Me.rdioRadio.Location = New System.Drawing.Point(25, 187)
        Me.rdioRadio.Name = "rdioRadio"
        Me.rdioRadio.Size = New System.Drawing.Size(59, 17)
        Me.rdioRadio.TabIndex = 25
        Me.rdioRadio.TabStop = True
        Me.rdioRadio.Text = "Raadio"
        Me.rdioRadio.UseVisualStyleBackColor = True
        '
        'rdioPrinter
        '
        Me.rdioPrinter.AutoSize = True
        Me.rdioPrinter.Location = New System.Drawing.Point(183, 95)
        Me.rdioPrinter.Name = "rdioPrinter"
        Me.rdioPrinter.Size = New System.Drawing.Size(55, 17)
        Me.rdioPrinter.TabIndex = 30
        Me.rdioPrinter.TabStop = True
        Me.rdioPrinter.Text = "Printer"
        Me.rdioPrinter.UseVisualStyleBackColor = True
        '
        'rdioEggCooker
        '
        Me.rdioEggCooker.AutoSize = True
        Me.rdioEggCooker.Location = New System.Drawing.Point(25, 210)
        Me.rdioEggCooker.Name = "rdioEggCooker"
        Me.rdioEggCooker.Size = New System.Drawing.Size(81, 17)
        Me.rdioEggCooker.TabIndex = 26
        Me.rdioEggCooker.TabStop = True
        Me.rdioEggCooker.Text = "Munakeetja"
        Me.rdioEggCooker.UseVisualStyleBackColor = True
        '
        'rdioHairDryer
        '
        Me.rdioHairDryer.AutoSize = True
        Me.rdioHairDryer.Location = New System.Drawing.Point(183, 72)
        Me.rdioHairDryer.Name = "rdioHairDryer"
        Me.rdioHairDryer.Size = New System.Drawing.Size(49, 17)
        Me.rdioHairDryer.TabIndex = 29
        Me.rdioHairDryer.TabStop = True
        Me.rdioHairDryer.Text = "Föön"
        Me.rdioHairDryer.UseVisualStyleBackColor = True
        '
        'rdioComputer
        '
        Me.rdioComputer.AutoSize = True
        Me.rdioComputer.Location = New System.Drawing.Point(183, 49)
        Me.rdioComputer.Name = "rdioComputer"
        Me.rdioComputer.Size = New System.Drawing.Size(52, 17)
        Me.rdioComputer.TabIndex = 28
        Me.rdioComputer.TabStop = True
        Me.rdioComputer.Text = "Arvuti"
        Me.rdioComputer.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(42, 559)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(332, 35)
        Me.btnConfirm.TabIndex = 15
        Me.btnConfirm.Text = "Kinnita andmed"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'tBoxPackagePrice
        '
        Me.tBoxPackagePrice.Location = New System.Drawing.Point(205, 497)
        Me.tBoxPackagePrice.Name = "tBoxPackagePrice"
        Me.tBoxPackagePrice.Size = New System.Drawing.Size(100, 20)
        Me.tBoxPackagePrice.TabIndex = 14
        '
        'lblCurrentPackagePrice
        '
        Me.lblCurrentPackagePrice.AutoSize = True
        Me.lblCurrentPackagePrice.Location = New System.Drawing.Point(39, 497)
        Me.lblCurrentPackagePrice.Name = "lblCurrentPackagePrice"
        Me.lblCurrentPackagePrice.Size = New System.Drawing.Size(127, 13)
        Me.lblCurrentPackagePrice.TabIndex = 10
        Me.lblCurrentPackagePrice.Text = "Kehtiva paketi tunnihind: "
        '
        'lblOptional
        '
        Me.lblOptional.AutoSize = True
        Me.lblOptional.Location = New System.Drawing.Point(46, 384)
        Me.lblOptional.Name = "lblOptional"
        Me.lblOptional.Size = New System.Drawing.Size(55, 13)
        Me.lblOptional.TabIndex = 4
        Me.lblOptional.Text = "Valikuline:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tarvitav võimsus ühes minutis:"
        '
        'lblApplianceChoice
        '
        Me.lblApplianceChoice.AutoSize = True
        Me.lblApplianceChoice.Location = New System.Drawing.Point(112, 22)
        Me.lblApplianceChoice.Name = "lblApplianceChoice"
        Me.lblApplianceChoice.Size = New System.Drawing.Size(93, 13)
        Me.lblApplianceChoice.TabIndex = 2
        Me.lblApplianceChoice.Text = "Kodumasina valik:"
        '
        'btnBack1
        '
        Me.btnBack1.Location = New System.Drawing.Point(18, 12)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(83, 33)
        Me.btnBack1.TabIndex = 1
        Me.btnBack1.Text = "Tagasi"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'tabExchangeComparison
        '
        Me.tabExchangeComparison.Controls.Add(Me.DataGridView1)
        Me.tabExchangeComparison.Controls.Add(Me.btnExport)
        Me.tabExchangeComparison.Controls.Add(Me.btnImport)
        Me.tabExchangeComparison.Controls.Add(Me.lblExchangeComparisonResult)
        Me.tabExchangeComparison.Controls.Add(Me.tBoxCondition2)
        Me.tabExchangeComparison.Controls.Add(Me.tBoxCondition1)
        Me.tabExchangeComparison.Controls.Add(Me.tBoxEndTime)
        Me.tabExchangeComparison.Controls.Add(Me.tboxStartTime)
        Me.tabExchangeComparison.Controls.Add(Me.lblExchangeChoice)
        Me.tabExchangeComparison.Controls.Add(Me.lblCase2)
        Me.tabExchangeComparison.Controls.Add(Me.lblCase1)
        Me.tabExchangeComparison.Controls.Add(Me.lblEnterPrice)
        Me.tabExchangeComparison.Controls.Add(Me.lblEndTime)
        Me.tabExchangeComparison.Controls.Add(Me.lblStartTime)
        Me.tabExchangeComparison.Controls.Add(Me.lblTimePeriodSelection)
        Me.tabExchangeComparison.Controls.Add(Me.btnBack2)
        Me.tabExchangeComparison.Location = New System.Drawing.Point(4, 26)
        Me.tabExchangeComparison.Name = "tabExchangeComparison"
        Me.tabExchangeComparison.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabExchangeComparison.Size = New System.Drawing.Size(912, 618)
        Me.tabExchangeComparison.TabIndex = 3
        Me.tabExchangeComparison.Text = "Börsihinna võrdlus"
        Me.tabExchangeComparison.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(237, 240)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(84, 34)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(128, 240)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(84, 34)
        Me.btnImport.TabIndex = 17
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'lblExchangeComparisonResult
        '
        Me.lblExchangeComparisonResult.AutoSize = True
        Me.lblExchangeComparisonResult.Location = New System.Drawing.Point(411, 22)
        Me.lblExchangeComparisonResult.Name = "lblExchangeComparisonResult"
        Me.lblExchangeComparisonResult.Size = New System.Drawing.Size(50, 13)
        Me.lblExchangeComparisonResult.TabIndex = 15
        Me.lblExchangeComparisonResult.Text = "Tulemus:"
        '
        'tBoxCondition2
        '
        Me.tBoxCondition2.Location = New System.Drawing.Point(197, 158)
        Me.tBoxCondition2.Name = "tBoxCondition2"
        Me.tBoxCondition2.Size = New System.Drawing.Size(100, 20)
        Me.tBoxCondition2.TabIndex = 14
        '
        'tBoxCondition1
        '
        Me.tBoxCondition1.Location = New System.Drawing.Point(197, 132)
        Me.tBoxCondition1.Name = "tBoxCondition1"
        Me.tBoxCondition1.Size = New System.Drawing.Size(100, 20)
        Me.tBoxCondition1.TabIndex = 13
        '
        'tBoxEndTime
        '
        Me.tBoxEndTime.Location = New System.Drawing.Point(197, 78)
        Me.tBoxEndTime.Name = "tBoxEndTime"
        Me.tBoxEndTime.Size = New System.Drawing.Size(100, 20)
        Me.tBoxEndTime.TabIndex = 12
        '
        'tboxStartTime
        '
        Me.tboxStartTime.Location = New System.Drawing.Point(197, 52)
        Me.tboxStartTime.Name = "tboxStartTime"
        Me.tboxStartTime.Size = New System.Drawing.Size(100, 20)
        Me.tboxStartTime.TabIndex = 11
        '
        'lblExchangeChoice
        '
        Me.lblExchangeChoice.AutoSize = True
        Me.lblExchangeChoice.Location = New System.Drawing.Point(107, 209)
        Me.lblExchangeChoice.Name = "lblExchangeChoice"
        Me.lblExchangeChoice.Size = New System.Drawing.Size(55, 13)
        Me.lblExchangeChoice.TabIndex = 8
        Me.lblExchangeChoice.Text = "Valikuline:"
        '
        'lblCase2
        '
        Me.lblCase2.AutoSize = True
        Me.lblCase2.Location = New System.Drawing.Point(107, 161)
        Me.lblCase2.Name = "lblCase2"
        Me.lblCase2.Size = New System.Drawing.Size(61, 13)
        Me.lblCase2.TabIndex = 7
        Me.lblCase2.Text = "Tingimus 2:"
        '
        'lblCase1
        '
        Me.lblCase1.AutoSize = True
        Me.lblCase1.Location = New System.Drawing.Point(107, 135)
        Me.lblCase1.Name = "lblCase1"
        Me.lblCase1.Size = New System.Drawing.Size(61, 13)
        Me.lblCase1.TabIndex = 6
        Me.lblCase1.Text = "Tingimus 1:"
        '
        'lblEnterPrice
        '
        Me.lblEnterPrice.AutoSize = True
        Me.lblEnterPrice.Location = New System.Drawing.Point(107, 111)
        Me.lblEnterPrice.Name = "lblEnterPrice"
        Me.lblEnterPrice.Size = New System.Drawing.Size(152, 13)
        Me.lblEnterPrice.TabIndex = 5
        Me.lblEnterPrice.Text = "Sisesta hinnastamistingimused:"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(107, 81)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(52, 13)
        Me.lblEndTime.TabIndex = 4
        Me.lblEndTime.Text = "Lõppaeg:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(107, 55)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(54, 13)
        Me.lblStartTime.TabIndex = 3
        Me.lblStartTime.Text = "Algusaeg:"
        '
        'lblTimePeriodSelection
        '
        Me.lblTimePeriodSelection.AutoSize = True
        Me.lblTimePeriodSelection.Location = New System.Drawing.Point(107, 22)
        Me.lblTimePeriodSelection.Name = "lblTimePeriodSelection"
        Me.lblTimePeriodSelection.Size = New System.Drawing.Size(96, 13)
        Me.lblTimePeriodSelection.TabIndex = 2
        Me.lblTimePeriodSelection.Text = "Ajavahemiku valik:"
        '
        'btnBack2
        '
        Me.btnBack2.Location = New System.Drawing.Point(18, 12)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(83, 33)
        Me.btnBack2.TabIndex = 1
        Me.btnBack2.Text = "Tagasi"
        Me.btnBack2.UseVisualStyleBackColor = True
        '
        'tabConsumptionHistory
        '
        Me.tabConsumptionHistory.Controls.Add(Me.btnSimulateConsumptionHistory)
        Me.tabConsumptionHistory.Controls.Add(Me.TabControl2)
        Me.tabConsumptionHistory.Controls.Add(Me.btnClientConsumptionHistory)
        Me.tabConsumptionHistory.Controls.Add(Me.btnBack3)
        Me.tabConsumptionHistory.Location = New System.Drawing.Point(4, 26)
        Me.tabConsumptionHistory.Name = "tabConsumptionHistory"
        Me.tabConsumptionHistory.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabConsumptionHistory.Size = New System.Drawing.Size(912, 618)
        Me.tabConsumptionHistory.TabIndex = 4
        Me.tabConsumptionHistory.Text = "Tarbimise ajalugu"
        Me.tabConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnSimulateConsumptionHistory
        '
        Me.btnSimulateConsumptionHistory.Location = New System.Drawing.Point(269, 17)
        Me.btnSimulateConsumptionHistory.Name = "btnSimulateConsumptionHistory"
        Me.btnSimulateConsumptionHistory.Size = New System.Drawing.Size(130, 80)
        Me.btnSimulateConsumptionHistory.TabIndex = 1
        Me.btnSimulateConsumptionHistory.Text = "Elektripakettide börsihindade ajalugu"
        Me.btnSimulateConsumptionHistory.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tabBlank)
        Me.TabControl2.Controls.Add(Me.tabClientConsumptionHistory)
        Me.TabControl2.Controls.Add(Me.tabSimulateExchangeHistory)
        Me.TabControl2.ItemSize = New System.Drawing.Size(42, 19)
        Me.TabControl2.Location = New System.Drawing.Point(0, 106)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(875, 494)
        Me.TabControl2.TabIndex = 2
        '
        'tabBlank
        '
        Me.tabBlank.Location = New System.Drawing.Point(4, 23)
        Me.tabBlank.Name = "tabBlank"
        Me.tabBlank.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabBlank.Size = New System.Drawing.Size(827, 450)
        Me.tabBlank.TabIndex = 0
        Me.tabBlank.Text = "Blank"
        Me.tabBlank.UseVisualStyleBackColor = True
        '
        'tabClientConsumptionHistory
        '
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblSimulateClientConsumptionHistory)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblComparisonGraph)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblConsumptionGraph)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblClientConsumptionHistoryResult)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblUploadComparisonPackageCSV)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblUploadClientHistoryCSV)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblHistoryData)
        Me.tabClientConsumptionHistory.Location = New System.Drawing.Point(4, 23)
        Me.tabClientConsumptionHistory.Name = "tabClientConsumptionHistory"
        Me.tabClientConsumptionHistory.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabClientConsumptionHistory.Size = New System.Drawing.Size(827, 450)
        Me.tabClientConsumptionHistory.TabIndex = 1
        Me.tabClientConsumptionHistory.Text = "Simuleeri oma tarbimise ajalugu"
        Me.tabClientConsumptionHistory.UseVisualStyleBackColor = True
        '
        'lblSimulateClientConsumptionHistory
        '
        Me.lblSimulateClientConsumptionHistory.AutoSize = True
        Me.lblSimulateClientConsumptionHistory.Location = New System.Drawing.Point(48, 23)
        Me.lblSimulateClientConsumptionHistory.Name = "lblSimulateClientConsumptionHistory"
        Me.lblSimulateClientConsumptionHistory.Size = New System.Drawing.Size(153, 13)
        Me.lblSimulateClientConsumptionHistory.TabIndex = 6
        Me.lblSimulateClientConsumptionHistory.Text = "Simuleeri oma tarbimise ajalugu"
        '
        'lblComparisonGraph
        '
        Me.lblComparisonGraph.AutoSize = True
        Me.lblComparisonGraph.Location = New System.Drawing.Point(573, 282)
        Me.lblComparisonGraph.Name = "lblComparisonGraph"
        Me.lblComparisonGraph.Size = New System.Drawing.Size(74, 13)
        Me.lblComparisonGraph.TabIndex = 5
        Me.lblComparisonGraph.Text = "Võrdlusgraafik"
        '
        'lblConsumptionGraph
        '
        Me.lblConsumptionGraph.AutoSize = True
        Me.lblConsumptionGraph.Location = New System.Drawing.Point(573, 114)
        Me.lblConsumptionGraph.Name = "lblConsumptionGraph"
        Me.lblConsumptionGraph.Size = New System.Drawing.Size(78, 13)
        Me.lblConsumptionGraph.TabIndex = 4
        Me.lblConsumptionGraph.Text = "Tarbimisgraafik"
        '
        'lblClientConsumptionHistoryResult
        '
        Me.lblClientConsumptionHistoryResult.AutoSize = True
        Me.lblClientConsumptionHistoryResult.Location = New System.Drawing.Point(426, 73)
        Me.lblClientConsumptionHistoryResult.Name = "lblClientConsumptionHistoryResult"
        Me.lblClientConsumptionHistoryResult.Size = New System.Drawing.Size(50, 13)
        Me.lblClientConsumptionHistoryResult.TabIndex = 3
        Me.lblClientConsumptionHistoryResult.Text = "Tulemus:"
        '
        'lblUploadComparisonPackageCSV
        '
        Me.lblUploadComparisonPackageCSV.AutoSize = True
        Me.lblUploadComparisonPackageCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblUploadComparisonPackageCSV.Location = New System.Drawing.Point(48, 212)
        Me.lblUploadComparisonPackageCSV.Name = "lblUploadComparisonPackageCSV"
        Me.lblUploadComparisonPackageCSV.Size = New System.Drawing.Size(156, 13)
        Me.lblUploadComparisonPackageCSV.TabIndex = 2
        Me.lblUploadComparisonPackageCSV.Text = "Lae üles võrreldava paketi CSV"
        '
        'lblUploadClientHistoryCSV
        '
        Me.lblUploadClientHistoryCSV.AutoSize = True
        Me.lblUploadClientHistoryCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblUploadClientHistoryCSV.Location = New System.Drawing.Point(48, 114)
        Me.lblUploadClientHistoryCSV.Name = "lblUploadClientHistoryCSV"
        Me.lblUploadClientHistoryCSV.Size = New System.Drawing.Size(185, 13)
        Me.lblUploadClientHistoryCSV.TabIndex = 1
        Me.lblUploadClientHistoryCSV.Text = "Lae üles oma tarbimise ajaloo CSV fail"
        '
        'lblHistoryData
        '
        Me.lblHistoryData.AutoSize = True
        Me.lblHistoryData.Location = New System.Drawing.Point(48, 73)
        Me.lblHistoryData.Name = "lblHistoryData"
        Me.lblHistoryData.Size = New System.Drawing.Size(80, 13)
        Me.lblHistoryData.TabIndex = 0
        Me.lblHistoryData.Text = "Ajaloo andmed:"
        '
        'tabSimulateExchangeHistory
        '
        Me.tabSimulateExchangeHistory.Controls.Add(Me.lblExchangePackageHistory)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.Label8)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.btnSeeHistory)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.tBoxMonthlyCost2)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.Label9)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.RadioButton3)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.RadioButton4)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.Label10)
        Me.tabSimulateExchangeHistory.Location = New System.Drawing.Point(4, 23)
        Me.tabSimulateExchangeHistory.Name = "tabSimulateExchangeHistory"
        Me.tabSimulateExchangeHistory.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabSimulateExchangeHistory.Size = New System.Drawing.Size(867, 467)
        Me.tabSimulateExchangeHistory.TabIndex = 2
        Me.tabSimulateExchangeHistory.Text = "Elektripakettide börsihindade ajalugu"
        Me.tabSimulateExchangeHistory.UseVisualStyleBackColor = True
        '
        'lblExchangePackageHistory
        '
        Me.lblExchangePackageHistory.AutoSize = True
        Me.lblExchangePackageHistory.Location = New System.Drawing.Point(48, 23)
        Me.lblExchangePackageHistory.Name = "lblExchangePackageHistory"
        Me.lblExchangePackageHistory.Size = New System.Drawing.Size(180, 13)
        Me.lblExchangePackageHistory.TabIndex = 20
        Me.lblExchangePackageHistory.Text = "Elektripakettide börsihindade ajalugu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(514, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tulemus:"
        '
        'btnSeeHistory
        '
        Me.btnSeeHistory.Location = New System.Drawing.Point(200, 241)
        Me.btnSeeHistory.Name = "btnSeeHistory"
        Me.btnSeeHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnSeeHistory.TabIndex = 18
        Me.btnSeeHistory.Text = "Kuva ajalugu"
        Me.btnSeeHistory.UseVisualStyleBackColor = True
        '
        'tBoxMonthlyCost2
        '
        Me.tBoxMonthlyCost2.Location = New System.Drawing.Point(175, 199)
        Me.tBoxMonthlyCost2.Name = "tBoxMonthlyCost2"
        Me.tBoxMonthlyCost2.Size = New System.Drawing.Size(100, 20)
        Me.tBoxMonthlyCost2.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Kuutasu"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(176, 145)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton3.TabIndex = 15
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Fikseeritud hind"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(51, 145)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Börsihind"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Kehtiva paketi andmete sisestus:"
        '
        'btnClientConsumptionHistory
        '
        Me.btnClientConsumptionHistory.Location = New System.Drawing.Point(133, 17)
        Me.btnClientConsumptionHistory.Name = "btnClientConsumptionHistory"
        Me.btnClientConsumptionHistory.Size = New System.Drawing.Size(130, 80)
        Me.btnClientConsumptionHistory.TabIndex = 0
        Me.btnClientConsumptionHistory.Text = "Simuleeri oma tarbimise ajalugu"
        Me.btnClientConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnBack3
        '
        Me.btnBack3.Location = New System.Drawing.Point(18, 12)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(83, 33)
        Me.btnBack3.TabIndex = 1
        Me.btnBack3.Text = "Tagasi"
        Me.btnBack3.UseVisualStyleBackColor = True
        '
        'tabPackageComparison
        '
        Me.tabPackageComparison.Controls.Add(Me.btnPackets)
        Me.tabPackageComparison.Controls.Add(Me.chartPackages)
        Me.tabPackageComparison.Controls.Add(Me.btnCompare)
        Me.tabPackageComparison.Controls.Add(Me.lblComparisonResult)
        Me.tabPackageComparison.Controls.Add(Me.cBoxPackage2)
        Me.tabPackageComparison.Controls.Add(Me.cBoxPackage1)
        Me.tabPackageComparison.Controls.Add(Me.Label6)
        Me.tabPackageComparison.Controls.Add(Me.lblPackage1)
        Me.tabPackageComparison.Controls.Add(Me.lblChoosePackages)
        Me.tabPackageComparison.Controls.Add(Me.btnBack4)
        Me.tabPackageComparison.Location = New System.Drawing.Point(4, 26)
        Me.tabPackageComparison.Name = "tabPackageComparison"
        Me.tabPackageComparison.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabPackageComparison.Size = New System.Drawing.Size(938, 619)
        Me.tabPackageComparison.TabIndex = 5
        Me.tabPackageComparison.Text = "Elektripakettide võrdlus"
        Me.tabPackageComparison.UseVisualStyleBackColor = True
        '
        'btnPackets
        '
        Me.btnPackets.Location = New System.Drawing.Point(48, 362)
        Me.btnPackets.Name = "btnPackets"
        Me.btnPackets.Size = New System.Drawing.Size(83, 33)
        Me.btnPackets.TabIndex = 10
        Me.btnPackets.Text = "Paketid"
        Me.btnPackets.UseVisualStyleBackColor = True
        '
        'chartPackages
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartPackages.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartPackages.Legends.Add(Legend3)
        Me.chartPackages.Location = New System.Drawing.Point(441, 112)
        Me.chartPackages.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chartPackages.Name = "chartPackages"
        Me.chartPackages.Size = New System.Drawing.Size(446, 283)
        Me.chartPackages.TabIndex = 9
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(178, 362)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(121, 33)
        Me.btnCompare.TabIndex = 8
        Me.btnCompare.Text = "Võrdle"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'lblComparisonResult
        '
        Me.lblComparisonResult.AutoSize = True
        Me.lblComparisonResult.Location = New System.Drawing.Point(438, 64)
        Me.lblComparisonResult.Name = "lblComparisonResult"
        Me.lblComparisonResult.Size = New System.Drawing.Size(50, 13)
        Me.lblComparisonResult.TabIndex = 7
        Me.lblComparisonResult.Text = "Tulemus:"
        '
        'cBoxPackage2
        '
        Me.cBoxPackage2.FormattingEnabled = True
        Me.cBoxPackage2.Location = New System.Drawing.Point(178, 281)
        Me.cBoxPackage2.Name = "cBoxPackage2"
        Me.cBoxPackage2.Size = New System.Drawing.Size(121, 21)
        Me.cBoxPackage2.TabIndex = 6
        '
        'cBoxPackage1
        '
        Me.cBoxPackage1.FormattingEnabled = True
        Me.cBoxPackage1.Location = New System.Drawing.Point(178, 157)
        Me.cBoxPackage1.Name = "cBoxPackage1"
        Me.cBoxPackage1.Size = New System.Drawing.Size(121, 21)
        Me.cBoxPackage1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Elektripakett 2:"
        '
        'lblPackage1
        '
        Me.lblPackage1.AutoSize = True
        Me.lblPackage1.Location = New System.Drawing.Point(53, 160)
        Me.lblPackage1.Name = "lblPackage1"
        Me.lblPackage1.Size = New System.Drawing.Size(78, 13)
        Me.lblPackage1.TabIndex = 3
        Me.lblPackage1.Text = "Elektripakett 1:"
        '
        'lblChoosePackages
        '
        Me.lblChoosePackages.AutoSize = True
        Me.lblChoosePackages.Location = New System.Drawing.Point(53, 64)
        Me.lblChoosePackages.Name = "lblChoosePackages"
        Me.lblChoosePackages.Size = New System.Drawing.Size(93, 13)
        Me.lblChoosePackages.TabIndex = 2
        Me.lblChoosePackages.Text = "Vali elektripaketid:"
        '
        'btnBack4
        '
        Me.btnBack4.Location = New System.Drawing.Point(18, 12)
        Me.btnBack4.Name = "btnBack4"
        Me.btnBack4.Size = New System.Drawing.Size(83, 33)
        Me.btnBack4.TabIndex = 1
        Me.btnBack4.Text = "Tagasi"
        Me.btnBack4.UseVisualStyleBackColor = True
        '
        'lblChangeFontSize
        '
        Me.lblChangeFontSize.AutoSize = True
        Me.lblChangeFontSize.Location = New System.Drawing.Point(128, 13)
        Me.lblChangeFontSize.Name = "lblChangeFontSize"
        Me.lblChangeFontSize.Size = New System.Drawing.Size(142, 13)
        Me.lblChangeFontSize.TabIndex = 7
        Me.lblChangeFontSize.Text = "MUUDA FONDI SUURUST:"
        '
        'btnFontIncrease
        '
        Me.btnFontIncrease.Location = New System.Drawing.Point(323, 6)
        Me.btnFontIncrease.Name = "btnFontIncrease"
        Me.btnFontIncrease.Size = New System.Drawing.Size(23, 27)
        Me.btnFontIncrease.TabIndex = 8
        Me.btnFontIncrease.Text = "+"
        Me.btnFontIncrease.UseVisualStyleBackColor = True
        '
        'btnFontDecrease
        '
        Me.btnFontDecrease.Location = New System.Drawing.Point(352, 6)
        Me.btnFontDecrease.Name = "btnFontDecrease"
        Me.btnFontDecrease.Size = New System.Drawing.Size(23, 27)
        Me.btnFontDecrease.TabIndex = 9
        Me.btnFontDecrease.Text = "-"
        Me.btnFontDecrease.UseVisualStyleBackColor = True
        '
        'btnRestoreFontSize
        '
        Me.btnRestoreFontSize.Location = New System.Drawing.Point(381, 6)
        Me.btnRestoreFontSize.Name = "btnRestoreFontSize"
        Me.btnRestoreFontSize.Size = New System.Drawing.Size(168, 27)
        Me.btnRestoreFontSize.TabIndex = 10
        Me.btnRestoreFontSize.Text = "Taasta fondi suurus"
        Me.btnRestoreFontSize.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(414, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(387, 222)
        Me.DataGridView1.TabIndex = 19
        '
        'GUIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 698)
        Me.Controls.Add(Me.btnRestoreFontSize)
        Me.Controls.Add(Me.btnFontDecrease)
        Me.Controls.Add(Me.btnFontIncrease)
        Me.Controls.Add(Me.lblChangeFontSize)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUIMain"
        Me.Text = "Elektri paketi kalkulaator"
        Me.TabControl1.ResumeLayout(False)
        Me.Main.ResumeLayout(False)
        CType(Me.chrtFrontPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPackageHourlyRate.ResumeLayout(False)
        Me.tabPackageHourlyRate.PerformLayout()
        CType(Me.chrtPackageHourlyRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblPriceTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabApplianceCalc.ResumeLayout(False)
        Me.tabApplianceCalc.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabExchangeComparison.ResumeLayout(False)
        Me.tabExchangeComparison.PerformLayout()
        Me.tabConsumptionHistory.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tabClientConsumptionHistory.ResumeLayout(False)
        Me.tabClientConsumptionHistory.PerformLayout()
        Me.tabSimulateExchangeHistory.ResumeLayout(False)
        Me.tabSimulateExchangeHistory.PerformLayout()
        Me.tabPackageComparison.ResumeLayout(False)
        Me.tabPackageComparison.PerformLayout()
        CType(Me.chartPackages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents btnPackageHourlyRate As Button
    Friend WithEvents btnApplianceCalc As Button
    Friend WithEvents btnExchangePriceComparison As Button
    Friend WithEvents btnConsumptionHistory As Button
    Friend WithEvents btnPackageComparison As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Main As TabPage
    Friend WithEvents tabPackageHourlyRate As TabPage
    Friend WithEvents btnBack0 As Button
    Friend WithEvents tabApplianceCalc As TabPage
    Friend WithEvents tabExchangeComparison As TabPage
    Friend WithEvents tabConsumptionHistory As TabPage
    Friend WithEvents tabPackageComparison As TabPage
    Friend WithEvents btnBack1 As Button
    Friend WithEvents btnBack2 As Button
    Friend WithEvents btnBack3 As Button
    Friend WithEvents btnBack4 As Button
    Friend WithEvents lblPackageHourly As Label
    Friend WithEvents rdioExchange As RadioButton
    Friend WithEvents lblPriceGraph As Label
    Friend WithEvents lblPriceTable As Label
    Friend WithEvents lblPackageHourlyRate As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnConfirmInput As Button
    Friend WithEvents tboxMonthlyCost As TextBox
    Friend WithEvents lblMonthlyCost As Label
    Friend WithEvents rdioFixedPrice As RadioButton
    Friend WithEvents tBoxPackageHourlyRate As TextBox
    Friend WithEvents lblRoughPrice As Label
    Friend WithEvents lblElectricityConsumptionRate As Label
    Friend WithEvents lblOptional As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblApplianceChoice As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents tBoxPackagePrice As TextBox
    Friend WithEvents rdioFixedPrice1 As RadioButton
    Friend WithEvents rdioExchangePrice As RadioButton
    Friend WithEvents lblCurrentPackagePrice As Label
    Friend WithEvents lblApplianceResult As Label
    Friend WithEvents rdioEggCooker As RadioButton
    Friend WithEvents rdioRadio As RadioButton
    Friend WithEvents rdioTV As RadioButton
    Friend WithEvents rdioFoodProcessor As RadioButton
    Friend WithEvents rdioElecStove As RadioButton
    Friend WithEvents rdioMixer As RadioButton
    Friend WithEvents rdioVacuum As RadioButton
    Friend WithEvents rdioToaster As RadioButton
    Friend WithEvents rdioCoffeeMaker As RadioButton
    Friend WithEvents tBoxApproxPrice As TextBox
    Friend WithEvents tBoxElectricityConsumptionRate As TextBox
    Friend WithEvents rdioLED As RadioButton
    Friend WithEvents rdioPrinter As RadioButton
    Friend WithEvents rdioHairDryer As RadioButton
    Friend WithEvents rdioComputer As RadioButton
    Friend WithEvents rdioFridge As RadioButton
    Friend WithEvents rdioMicrowave As RadioButton
    Friend WithEvents rdioRouter As RadioButton
    Friend WithEvents rdioSewingMachine As RadioButton
    Friend WithEvents lblExchangeChoice As Label
    Friend WithEvents lblCase2 As Label
    Friend WithEvents lblCase1 As Label
    Friend WithEvents lblEnterPrice As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblTimePeriodSelection As Label
    Friend WithEvents tBoxCondition2 As TextBox
    Friend WithEvents tBoxCondition1 As TextBox
    Friend WithEvents tBoxEndTime As TextBox
    Friend WithEvents tboxStartTime As TextBox
    Friend WithEvents lblExchangeComparisonResult As Label
    Friend WithEvents btnSimulateConsumptionHistory As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents tabBlank As TabPage
    Friend WithEvents tabClientConsumptionHistory As TabPage
    Friend WithEvents tabSimulateExchangeHistory As TabPage
    Friend WithEvents btnClientConsumptionHistory As Button
    Friend WithEvents lblComparisonGraph As Label
    Friend WithEvents lblConsumptionGraph As Label
    Friend WithEvents lblClientConsumptionHistoryResult As Label
    Friend WithEvents lblUploadComparisonPackageCSV As Label
    Friend WithEvents lblUploadClientHistoryCSV As Label
    Friend WithEvents lblHistoryData As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSeeHistory As Button
    Friend WithEvents tBoxMonthlyCost2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSimulateClientConsumptionHistory As Label
    Friend WithEvents lblExchangePackageHistory As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPackage1 As Label
    Friend WithEvents lblChoosePackages As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents lblComparisonResult As Label
    Friend WithEvents cBoxPackage2 As ComboBox
    Friend WithEvents cBoxPackage1 As ComboBox
    Friend WithEvents tBoxUsageTime As TextBox
    Friend WithEvents lblUsageTime As Label
    Friend WithEvents lblConsumptionPerHour As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tBoxConsumptionPerHour As TextBox
    Friend WithEvents lblCents As Label
    Friend WithEvents lblKwh24h As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblWatt As Label
    Friend WithEvents tblPriceTable As DataGridView
    Friend WithEvents chrtPackageHourlyRate As DataVisualization.Charting.Chart
    Friend WithEvents chrtFrontPage As DataVisualization.Charting.Chart
    Friend WithEvents btnChartAsc As Button
    Friend WithEvents btnTaasta As Button
    Friend WithEvents btnSisesta As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rdioUniversalPackage As RadioButton
    Friend WithEvents cbColor As ComboBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents lblChangeFontSize As Label
    Friend WithEvents btnFontIncrease As Button
    Friend WithEvents btnFontDecrease As Button
    Friend WithEvents btnRestoreFontSize As Button
    Friend WithEvents radioStockPlusMore As RadioButton
    Friend WithEvents tBoxMarginal As TextBox
    Friend WithEvents lblMore As Label
    Friend WithEvents lblSKwh2 As Label
    Friend WithEvents lblSKwh1 As Label
    Friend WithEvents btnPackets As Button
    Friend WithEvents chartPackages As DataVisualization.Charting.Chart
    Friend WithEvents DataGridView1 As DataGridView
End Class
