using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Product> Products { get; set; }  //Каждый DbSet это доступ к определённой таблице в базе данных
        public DbSet<Cart> Carts { get; set; } 
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<ComparingProduct> ComparingProducts { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate(); //Создается база данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new List<Product>()
        {
          new Product("Спиннинг", 3000, "Все модели оснащены легкими пропускными кольцами, опоры которых имеют форму, препятствующую захлестам. Оригинальные катушкодержатели удобно лежат в руке и обеспечивают максимальную тактильную чувствительность.", "https://fmagazin.ru/_files/editor/images/pic/herakles/spinning_herakles_red_creek_ml_1_98m_5_20g_m.jpg"),
          new Product("Катушка", 4000, "Легкий корпус из высокопрочного пластика, плавный равномерный ход и замечательные тяговые характеристики. Моментальный антиреверс. Алюминиевая шпуля с насечкой и коническим буртиком.", "https://fmagazin.ru/_files/editor/images/pic/volzhanka/katushka_volzhanka_tajfun_5500_m.jpg"),
          new Product("Леска", 500, "Плетеный шнур изготовленный по технологии четырехжильного плетения – две жилы из высокомолекулярного полиэтилена, две – из полиэстера", "https://fmagazin.ru/_files/editor/images/pic/sunline/monofilnaya_leska/leska_sunline_bass_special_100m_0_190mm_jungle_green_m.jpg"),
          new Product("Эхолот", 10000, "Дальность работы:50 метров Глубина сканирования:50 метров Луч сканирования:40 градусов GPS модуль:Нет Вес:65 грамм", "https://rusonar.ru/upload/medialibrary/331/33179e13dd1369b9f82a1c162fd8c6b0.png"),
          new Product("Рыболовное кресло", 15000, "Регулируемые по высоте опоры позволяют удобно расположиться практически на любом берегу, а сиденье, вращающееся на 360 градусов, обеспечит комфортную рыбалку без усталости спины.", "https://cdn1.ozone.ru/s3/multimedia-4/c500/6018863824.jpg"),
          new Product("Прикормка", 150, "Подойдёт для ловли как в озёрах, так и в небольших каналах и медленно текущих реках. Отлично держится в кормушке.", "https://images.spinningline.ru/00127414_LARGE-001.jpg"),
          new Product("Комплект сигнализаторов поклёвки", 2000, "Сигнализатор имеет влагозащиту, что позволяет использовать его в самых суровых условиях.","https://fmagazin.ru/_files/editor/images/pic/anaconda/komplekt_signalizatorov_s_pejdzherom_anaconda_tsr_2_way_set_2_1_red_green_m.jpg"),
          new Product("Поплавок", 100, "Поплавки Iron Trout Trolling Float идеально подходят для ловли форели в проводку с яркими шариками на дальней дистанции", "https://fmagazin.ru/_files/editor/images/pic/colmic/poplavok_colmic_cooper_1g_m.jpg"),
          new Product("Рюкзак", 800, "Рюкзак имеет основное отделение, куда помещаются коробки с инструментами и приманками, дополнительное отделение, два боковых кармана для размещения бутылок с водой или другого груза.", "https://fmagazin.ru/_files/editor/images/pic/rap/ryukzak_rapala_jungle_rjubp_m.jpg"),
          new Product("Нож складной", 2500, "Включает в себя нож, пассатижи, отвертки, штопор и.т.д. Все, кроме декоративных пластмассовых накладок, выполнено из нержавеющей стали.", "https://fmagazin.ru/_files/editor/images/pic/aqua/nozh_skladnoj_aqua_ak_p802_m.jpg"),
          new Product("Фонарь налобный", 600,"В поворотном отражателе этого налобного фонаря собраны 6 LED SMD-светодиодов. Они создают равномерный яркий свет для освещения объектов на переднем и среднем планах в темноте.", "https://fmagazin.ru/_files/editor/images/pic/sledopyt/fonar_nalobnyj_sibirskij_sledopyt_lyuminofor_m.jpg"),
          new Product("Весы", 300, "Матовая чёрная поверхность не бликует на солнце, а контрастная шкала облегчает замер при слабом освещении. Корпус и линза весов выполнены их прочных композитных материалов, а подвес и крюк для взвешивания – из нержавеющей стали.", "https://fmagazin.ru/_files/editor/images/pic/prologic/vesy_mekhanicheskie_prologic_specimen_dial_scale_60lbs_27kg_m.jpg")
        });
        }
    }
}
