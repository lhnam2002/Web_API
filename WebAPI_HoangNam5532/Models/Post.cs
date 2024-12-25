namespace WebAPI_HoangNam5532.Models
{
    public class Post
    {
        public int Id { get; set; }               // Mã bài đăng
        public string? Title { get; set; }         // Tiêu đề bài đăng
        public string? Content { get; set; }       // Nội dung bài đăng
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Ngày tạo
        public string? ImageUrl { get; set; }     // URL ảnh (tuỳ chọn)
        public int? LikeCount { get; set; } = 0;   // Số lượt thích (mặc định là 0)
    }
}
