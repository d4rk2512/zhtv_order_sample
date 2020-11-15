using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using zhtv.Models;

namespace zhtv
{
    public class OrderManager
    {
        // Đoạn này là singleton
        private OrderManager()
        {
            GetSongData();
            FillNextSongs();
        }

        private static OrderManager _instance;

        public static OrderManager Instance
        {
            get
            {
                if (_instance == null) _instance = new OrderManager();
                return _instance;
            }
        }

        // Dict chứa thông tin bài hát
        public Dictionary<int, Song> SongDatas = new Dictionary<int, Song>();

        // Thông tin order
        public List<OrderInfo> OrderInfos = new List<OrderInfo>();

        // List bài hát được order
        public List<Song> OrderSongs = new List<Song>();

        // Bài đang phát
        public Song PlayingSong = new Song();

        // Số bài hát tối thiểu ở hàng chờ
        private readonly int MinOrderSongNumber = 3;

        private void GetSongData()
        {
            // Đoạn này là lấy data cho thông tin bài hát, lấy từ google sheet ý
            SongDatas.Add(1, new Song { SongId = 1, Name = "Hạ Chí", Singer = "Âm Khuyết Thi Thính & Tiểu Hồn" });
            SongDatas.Add(2, new Song { SongId = 2, Name = "Thư hỏi mệnh", Singer = "Âm Khuyết Thi Thính & Côn Ngọc" });
            SongDatas.Add(3, new Song { SongId = 3, Name = "Bài ca con gà mái", Singer = "Âm Khuyết Thi Thính" });
            SongDatas.Add(4, new Song { SongId = 4, Name = "Cuốn sổ kỷ niệm", Singer = "Âm Khuyết Thi Thính & Vương Tử Ngọc" });
            SongDatas.Add(5, new Song { SongId = 5, Name = "Lập thu", Singer = "Âm Khuyết Thi Thính & Côn Ngọc" });
            SongDatas.Add(6, new Song { SongId = 6, Name = "Sau khi nhìn thấu", Singer = "Vương Tử Ngọc" });
            SongDatas.Add(7, new Song { SongId = 7, Name = "Bạn thân", Singer = "Âm Khuyết Thi Thính & Hạ Ninh Cáp" });
            SongDatas.Add(8, new Song { SongId = 8, Name = "Sát cánh cùng bạn", Singer = "Âm Khuyết Thi Thính" });
            SongDatas.Add(9, new Song { SongId = 9, Name = "Thiên Phủ", Singer = "Song Sênh" });
            SongDatas.Add(10, new Song { SongId = 10, Name = "Nhất tiễn mai - Hồng ngẫu hương tàn ngọc điệm thu", Singer = "Âm Khuyết Thi Thính & Âm Mưu Luận" });
        }

        private void FillNextSongs()
        {
            var currentOrder = OrderSongs.Count;

            //Đủ rồi thì thôi
            if (currentOrder >= MinOrderSongNumber) return;

            //Random đến khi đủ bài
            var allSongs = SongDatas.Count;
            var addSongNumber = Math.Min(MinOrderSongNumber - currentOrder, allSongs);

            var rand = new Random();

            while (OrderSongs.Count < MinOrderSongNumber)
            {
                var song = SongDatas[rand.Next(1, allSongs)];
                if (OrderSongs.Contains(song)) continue;
                OrderSongs.Add(song);
            }
        }

        public void OrderMultipleSongs(List<OrderInfo> orders)
        {
            foreach (var order in orders)
            {
                OrderSong(order);
            }
        }

        public void OrderSong(OrderInfo order)
        {
            if (!SongDatas.ContainsKey(order.SongId)) return;

            var index = OrderSongs.FindIndex(s => s.SongId == order.SongId);

            // Bài hát chưa được order, thêm vào list
            if (index == -1)
            {
                var addSong = SongDatas[order.SongId];
                addSong.UserOrders.Add(order.User);
                OrderSongs.Add(addSong);
                OrderSongs.Sort((a, b) => b.UserOrders.Count - a.UserOrders.Count);
                return;
            }

            var song = OrderSongs[index];

            // User đã order bài hát, bỏ qua
            if (song.UserOrders.Contains(order.User)) return;

            song.UserOrders.Add(order.User);
            OrderSongs.Sort((a, b) => b.UserOrders.Count - a.UserOrders.Count);
        }

        // Chuyển bài
        public void PlayNextSong()
        {
            var nextSong = OrderSongs[0];
            PlayingSong = nextSong;
            OrderSongs.RemoveAt(0);
            FillNextSongs();
        }
    }
}
