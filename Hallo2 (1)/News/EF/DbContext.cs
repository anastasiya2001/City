using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.EF
{
    public class DbCont : DbContext
    {
        public DbSet<Publication> _publications { get; set; }
        public DbSet<Reblicator> _rubrics { get; set; }
        private static List<Comment> _comments;
        private static List<ChatMessage> _chat;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-KBCOFVK; Database = news; Trusted_Connection = True;");
            base.OnConfiguring(optionsBuilder);
        }

        public void CreateDbIfNotExist()
        {
            this.Database.EnsureCreated();
        }

        public void DropDB()
        {
            this.Database.EnsureDeleted();
        }

        public DbSet<Publication> Publications
        {
            get
            {
                return _publications;
            }
        }

        public DbSet<Reblicator> Rubrics
        {
            get
            {
                return _rubrics;
            }
        }

        public List<Comment> Comments
        {
            get
            {
                return _comments;
            }
        }

        public List<ChatMessage> Chat
        {
            get
            {
                return _chat;
            }
        }

        public void AddRubricator()
        {
            _rubrics.AddRange(entities: new Reblicator[]
            {
                new Reblicator { Name = "Политика", Path = "Politic" },
                new Reblicator { Name = "Мода", Path = "Fashion" },
                new Reblicator { Name = "Культура", Path = "Culture" }
            });
        }

        public void AddPublication()
        {
            _publications.AddRange(entities: new Publication[]
            {
                new Publication {
                    Date = DateTime.Now,
                    Title = "Сегодня в стране",
                    Announce = "Идеи губернаторов войдут в список поручений Путина по соцподдержке граждан",
                    Body = "Предложения губернаторов российских регионов войдут в перечень поручений президента России Владимира Путина по итогам заседания президиума госсовета по социальной поддержке, сообщает пресс-служба Кремля.Отмечается, что 25 мая состоится заседание президиума Государственного Совета, где будут рассмотрены вопросы социальной поддержки граждан.<<Основой для подготовки традиционного перечня поручений президента по итогам заседания станут также предложения, выработанные на специальном семинаре-совещании с участием представителей губернаторского корпуса, состоявшемся накануне, 24 мая>>, - говорится в сообщении.",
                    Rubricator = _rubrics.First(t => t.Id==1),
                    Path = "Politic"
                },

                new Publication {
                    Date = DateTime.Now.AddDays(-1),
                    Title = "Gucci",
                    Announce = "Gucci стал самым дорогим итальянским брендом",
                    Body = "Британская компания по исследованию рынка Kantar составила ежегодный рейтинг самых дорогих брендов итальянской индустрии моды и поставила бренд Gucci на первое место в этом списке.Путем исследования стоимости брендов компания Kantar составила список Top 30 Most Valuable Italian Brands. Четвертый год подряд рейтинг в сфере индустрии моды возглавил Gucci, принадлежащий корпорации Kering. По данным Kantar, стоимость итальянского бренда выросла на 12% по сравнению с прошлым годом и составила $37,9 млрд. При этом стоимость Gucci составляет почти треть от общей стоимости всех итальянских брендов в рейтинге. Их общая стоимость оценивается в $128,7 млрд.",
                    Rubricator = _rubrics.First(t => t.Id==2),
                    Path= "Fashion"
                },

                new Publication {
                    Date = DateTime.Now.AddDays(-2),
                    Title = "Новости Культурной столицы",
                    Announce = "Эрмитаж в ближайший год не будет участвовать в выставках за рубежом",
                    Body = "Государственный Эрмитаж в ближайший год не будет участвовать в выставках за рубежом, сообщил генеральный директор музея Михаил Пиотровский. По его словам, в ближайшее время Эрмитаж реализует несколько крупных проектов, в том числе и в честь 350-летия Петра Первого. Пиотровский отметил, что проект продолжает серию выставок произведений искусства из коллекции Сергея Щукина, а также братьев Михаила и Ивана Морозовых, которые организуются с 2016 года в Петербурге, Москве и Париже.",
                    Rubricator = _rubrics.First(t => t.Id==3),
                    Path="Culture"
                }
            });
        }
        static DbCont()
        {
            _comments = new List<Comment>();

            _chat = new List<ChatMessage> { new ChatMessage { Date = DateTime.Now, Message = "Приветствуем наших читателей!" } };
        }
        public void Run()
        {
            DropDB();
            CreateDbIfNotExist();
            AddRubricator();
            SaveChanges();
            AddPublication();
            SaveChanges();
        }
    }
}
