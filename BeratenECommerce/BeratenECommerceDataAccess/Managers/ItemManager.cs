using BeratenECommerceDataAccess.DbModel;
using BeratenECommerceDataAccess.Ifaces;
using BeratenECommerceDomain.Models;

namespace BeratenECommerceDataAccess.Managers
{
    public class ItemManager: BaseDataManager, IItem
    {
        private List<Item> items;
        public ItemManager(BeratenECommerceModel context) : base(context) 
        {
            ItemData();
        }

        public IList<Item> GetIAlltems(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter)) return items;
            return items.Where(x=>x.Name.Contains(filter)).ToList();
        }

        public Item GetItem(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }

        //https://www.youtube.com/watch?v=6vwv7m-GQDU&t=353s&ab_channel=CodingJackpot
        public void ItemData()
        {
            items = new List<Item>()
            {
                new Item
                {
                    Id = 1,
                    Brand = "Brand A",
                    Name = "Fantastic Biscuits",
                    Color = "Red",
                    Price = 100,
                    Description = "This is item 1. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/1.jpeg",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 2,
                    Brand = "Over The Moon Cookies",
                    Name = "Over The Moon Cookies 2",
                    Color = "Blue",
                    Price = 200,
                    Description = "This is item 2. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/10.jpg",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 3,
                    Brand = "Biscuit Bliss Bakery",
                    Name = "Biscuit Bliss Bakery 3",
                    Color = "Green",
                    Price = 300,
                    Description = "This is item 3. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/12.jpg",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 4,
                    Brand = "Biscuit Bites Bakery",
                    Name = "Biscuit Bites Bakery 4",
                    Color = "Yellow",
                    Price = 400,
                    Description = "This is item 4. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/5.jpg",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 5,
                    Brand = "Biscuit Boutique",
                    Name = "Biscuit Boutique 5",
                    Color = "Purple",
                    Price = 500,
                    Description = "This is item 5. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/2.jpg",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 6,
                    Brand = "Better Baked Biscuits",
                    Name = "Better Baked Biscuits",
                    Color = "Black",
                    Price = 600,
                    Description = "This is item 6. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/3.jpeg",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 7,
                    Brand = "Cookie Crafters Bakery",
                    Name = "Cookie Crafters Bakery",
                    Color = "White",
                    Price = 700,
                    Description = "This is item 7. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/11.webp",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 8,
                    Brand = "Cookie Cottage",
                    Name = "Cookie Cottage",
                    Color = "Gray",
                    Price = 800,
                    Description = "This is item 8. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/13.webp",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 9,
                    Brand = "Cookie Cupboard",
                    Name = "Cookie Cupboard",
                    Color = "Orange",
                    Price = 900,
                    Description = "This is item 9. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/6.webp",
                    CartFlag = false,
                },
                new Item
                {
                    Id = 10,
                    Brand = "Crumbs & Cookies",
                    Name = "Crumbs & Cookies",
                    Color = "Pink",
                    Price = 1000,
                    Description = "This is item 10.It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n",
                    ImageLink = "images/4.webp",
                    CartFlag = false,
                },
            };
        }
    }
}
