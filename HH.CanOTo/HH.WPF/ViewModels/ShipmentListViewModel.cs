using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using HH.WPF.ViewModels;
using System.Security.Cryptography;

namespace HH.WPF.ViewModels;

public class ShipmentListViewModel : ViewModelBase
{
    public ShipmentListViewModel()
    {
        Items1 = CreateData();

        foreach (var model in Items1)
        {
            model.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(ShipmentModel.IsSelected))
                    OnPropertyChanged(nameof(IsAllItems1Selected));
            };
        }
    }

    public bool AddItem()
    {
        Items1.Add(new ShipmentModel
        {
            Id = RandomNumberGenerator.GetInt32(0, 100),
        });
        return true;
    }

    public bool? IsAllItems1Selected
    {
        get
        {
            var selected = Items1.Select(item => item.IsSelected).Distinct().ToList();
            return selected.Count == 1 ? selected.Single() : null;
        }
        set
        {
            if (value.HasValue)
            {
                SelectAll(value.Value, Items1);
                OnPropertyChanged();
            }
        }
    }

    private static void SelectAll(bool select, IEnumerable<ShipmentModel> models)
    {
        foreach (var model in models)
        {
            model.IsSelected = select;
        }
    }

    private static ObservableCollection<ShipmentModel> CreateData()
    {
        return new ObservableCollection<ShipmentModel>
        {
            //    public ShipmentModel(bool isSelected, int id, string? tenKhachHang, string? diaChi, string? loadHangHoa, string? bienSoXe, double? tlXeHang, double? tlXe, double? tlHang, double? giaMua, double? thanhTien, DateTime? ngayCan, DateTime? gioCanXe, DateTime? gioCanXac, string? ghiChu)
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),
            new ShipmentModel(),

        };
    }

    public ObservableCollection<ShipmentModel> Items1 { get; }

}
