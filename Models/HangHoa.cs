using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TranNgocKhanh_241230761.Models;

public class HangHoa
{
    [Key]
    public int MaHang { get; set; }

    [DisplayName("Mã loại")]
    public int MaLoai { get; set; }

    [DisplayName("Tên hàng")]
    [Required(ErrorMessage = "Tên hàng không được để trống")]
    [StringLength(100, ErrorMessage = "Tên hàng không được vượt quá 100 ký tự")]
    public string TenHang { get; set; } = null!;

    [DisplayName("Giá")]
    [Required(ErrorMessage = "Giá không được để trống")]
    [Range(100, 5000, ErrorMessage = "Giá phải nằm trong khoảng từ 100 đến 5000")]
    public decimal? Gia { get; set; }

    [DisplayName("Ảnh")]
    [RegularExpression(@"^.*\.(jpg|gif|png|tiff)$", ErrorMessage = "Ảnh phải có định dạng jpg, gif, png hoặc tiff")]
    public string? Anh { get; set; }

    public virtual LoaiHang MaLoaiNavigation { get; set; } = null!;
}
