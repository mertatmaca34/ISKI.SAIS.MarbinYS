using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinUI.Controls.IBKS;

public partial class DigitalSensorBar : UserControl
{
    [Category("IBKS"), Description("Kanal Adı")]
    public string ChannelName
    {
        get => LabelChannelName.Text;
        set => LabelChannelName.Text = value;
    }

    [Category("IBKS"), Description("Kanal Açıklaması")]
    public string ChannelDescription
    {
        get => LabelChannelDescription.Text;
        set => LabelChannelDescription.Text = value;
    }

    [Category("IBKS"), Description("Kanal Durumu"), DefaultValue(typeof(Color), "Gray")]
    public Color ChannelStateColor
    {
        get => PanelState.BackColor;
        set => PanelState.BackColor = value;
    }

    [Category("IBKS"), Description("1. Ayraç Görünürlüğü"), DefaultValue(true)]
    public bool Splitter1Visible
    {
        get => Splitter1.Visible;
        set => Splitter1.Visible = value;
    }

    [Category("IBKS"), Description("2. Ayraç Görünürlüğü"), DefaultValue(true)]
    public bool Splitter2Visible
    {
        get => Splitter2.Visible;
        set => Splitter2.Visible = value;
    }

    [Category("IBKS"), Description("Veri Durumu Arka Plan Rengi"), DefaultValue(typeof(Color), "Gray")]
    public Color DataStateColor
    {
        get => tableLayoutDataState.BackColor;
        set => tableLayoutDataState.BackColor = value;
    }

    [Category("IBKS"), Description("Veri Durumu Açıklaması")]
    public string DataStateDescription
    {
        get => LabelDataStateDescription.Text;
        set => LabelDataStateDescription.Text = value;
    }

    [Category("IBKS"), Description("Veri Durumu Başlık Yazı Rengi")]
    public Color DataStateTitleColor
    {
        get => LabelDataStateTitle.ForeColor;
        set => LabelDataStateTitle.ForeColor = value;
    }

    [Category("IBKS"), Description("Veri Durumu Açıklama Yazı Rengi")]
    public Color DataStateDescriptionColor
    {
        get => LabelDataStateDescription.ForeColor;
        set => LabelDataStateDescription.ForeColor = value;
    }

    [Category("IBKS"), Description("Sistem Durumu Başlık Yazı Rengi")]
    public Color SystemStateTitleColor
    {
        get => LabelSystemStateTitle.ForeColor;
        set => LabelSystemStateTitle.ForeColor = value;
    }

    [Category("IBKS"), Description("Sistem Durumu Açıklama Yazı Rengi")]
    public Color SystemStateDescriptionColor
    {
        get => LabelSystemStateDescription.ForeColor;
        set => LabelSystemStateDescription.ForeColor = value;
    }

    [Category("IBKS"), Description("Sistem Durumu Açıklaması")]
    public string SystemStateDescription
    {
        get => LabelSystemStateDescription.Text;
        set => LabelSystemStateDescription.Text = value;
    }

    public DigitalSensorBar()
    {
        InitializeComponent();
    }
}