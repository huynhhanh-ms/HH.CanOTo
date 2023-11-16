using System;
using System.Runtime.CompilerServices;

namespace HH.WPF.ViewModels;

public class ShipmentModel : ViewModelBase
{
    private bool _isSelected;

    private int _id;
    private string? _tenKhachHang;
    private string? _diaChi;
    private string? _loaiHangHoa;
    private string? _bienSoXe;
    private double? _tlXeHang = 0;
    private double? _tlXe = 0;
    private double? _tlHang = 0;
    private double? _giaMua = 0;
    private double? _thanhTien = 0;
    private DateTime? _ngayCan;
    private DateTime? _gioCanXe;
    private DateTime? _gioCanXac;
    private string? _ghiChu;

    public ShipmentModel()
    {
    }

    public ShipmentModel(bool isSelected, int id, string? tenKhachHang, string? diaChi, string? loaiHangHoa, string? bienSoXe, double? tlXeHang, double? tlXe, double? tlHang, double? giaMua, double? thanhTien, DateTime? ngayCan, DateTime? gioCanXe, DateTime? gioCanXac, string? ghiChu)
    {
        IsSelected = isSelected;
        Id = id;
        TenKhachHang = tenKhachHang;
        DiaChi = diaChi;
        LoaiHangHoa = loaiHangHoa;
        BienSoXe = bienSoXe;
        TlXeHang = tlXeHang;
        TlXe = tlXe;
        TlHang = tlHang;
        GiaMua = giaMua;
        ThanhTien = thanhTien;
        NgayCan = ngayCan;
        GioCanXe = gioCanXe;
        GioCanXac = gioCanXac;
        GhiChu = ghiChu;
    }

    public bool IsSelected
    {
        get => _isSelected;
        set => SetProperty(ref _isSelected, value);
    }

    public int Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    public string? TenKhachHang
    {
        get => _tenKhachHang;
        set => SetProperty(ref _tenKhachHang, value);
    }

    public string? DiaChi
    {
        get => _diaChi;
        set => SetProperty(ref _diaChi, value);
    }

    public string? LoaiHangHoa
    {
        get => _loaiHangHoa;
        set => SetProperty(ref _loaiHangHoa, value);
    }

    public string? BienSoXe
    {
        get => _bienSoXe;
        set => SetProperty(ref _bienSoXe, value);
    }

    public double? TlXeHang
    {
        get => _tlXeHang;
        set => SetProperty(ref _tlXeHang, value);
    }

    public double? TlXe
    {
        get => _tlXe;
        set => SetProperty(ref _tlXe, value);
    }

    public double? TlHang
    {
        get => _tlHang;
        set => SetProperty(ref _tlHang, value);
    }

    public double? GiaMua
    {
        get => _giaMua;
        set => SetProperty(ref _giaMua, value);
    }

    public double? ThanhTien
    {
        get => _thanhTien;
        set => SetProperty(ref _thanhTien, value);
    }

    public DateTime? NgayCan
    {
        get => _ngayCan;
        set => SetProperty(ref _ngayCan, value);
    }

    public DateTime? GioCanXe
    {
        get => _gioCanXe;
        set => SetProperty(ref _gioCanXe, value);
    }

    public DateTime? GioCanXac
    {
        get => _gioCanXac;
        set => SetProperty(ref _gioCanXac, value);
    }

    public string? GhiChu
    {
        get => _ghiChu;
        set => SetProperty(ref _ghiChu, value);
    }

}
