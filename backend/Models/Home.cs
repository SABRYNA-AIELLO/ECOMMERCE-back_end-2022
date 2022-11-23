namespace backend.Models
{
    public class Home
    {
        public class HomeInfo
        {
            public Header header { get; set; }
            public Footer footer { get; set; }

            public HomeInfo()
            {
                this.header = new Header();
                this.footer = new Footer();
            }
        }

    }
}
