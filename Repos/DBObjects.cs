﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Repos
{
    public class DBObjects
    {
         public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c=> c.Value));
                
            if (!content.Guitar.Any())
            {
                content.AddRange(
                    new Guitar
                    {
                        name = "LTD EC - 1000",
                        shortDesc = "электрогитара, цвет чёрный silverburst, " +
                        "корпус - 	красное дерево, гриф - 	красное дерево, накладка грифа - черное дерево, " +
                        "лады - 24 XJ, мензура 25,5`, звукосниматели - H/H EMG 81/60, " +
                        "регуляторы - грмкость, тон, 3-позиционный переключатель звукоснимателей, ",
                        longDesc = "Возьмите в руки электрогитару ESP LTD EC-1000, и вы поверите, что этот изящный и легкий инструмент способен на всё. В этой гитаре сделано все для максимальной отдачи - корпус из красного дерева с кленовым топом, вклеенный гриф с палисандровой или эбеновой накладкой, бридж TonePros Tune-o-matic (некоторые модели комплектуются Floyd Rose или Ever-tune), знаменитые своим 'выхлопом' активные звукосниматели EMG или пассивные Seymour Duncan. Не стоит забывать, что гитары ESP LTD EC-1000 известны своим качеством исполнения и потрясающе красивыми вариантами покрытия.",
                        img = "/img/ltd_ec_1000_ssb_l_1.jpg",
                        price = 63000,
                        ifFavourite = true,
                        available = true,
                        Category = Categories["Электрогитары_6"]
                    },
                     new Guitar
                     {
                         name = "IBANEZ GIO",
                         shortDesc = "электрогитара, цвет чёрный матовый," +
                         " корпус - тополь, гриф - клён, накладка грифа - новозеландская сосна, " +
                         "лады - 24 Jumbo, мензура 25,5`, звукосниматели - H/H IBZ6, регуляторы - грмкость, " +
                         "тон, 3-позиционный переключатель звукоснимателей, фурнитура- цвет чёрный.",
                         longDesc = "IBANEZ GIO GRG121DX-BKF BLACK FLAT - это шестиструнная электрогитара популярной линейки GRG. Электрогитара имеет аутентичное роковое звучание, классический стиль деки и головы грифа. Электрогитара оборудована кленовым грифом с накладкой из палисандра. Маркеры ладов выполнены в виде классических акульих зубов белого цвета. Крепление грифа к деке выполнено на винтах. Инструмент пользуется популярностью среди гитаристов, играющих рок и мелодичную инструментальную музыку. На деку установлен фиксированный бридж от производителя. Количество ладов грифа - 24, тип ладов - Jumbo. Цвет гитары черный матовый, фурнитура черного цвета.",
                         img = "/img/Ibanez_gio_grg121.jpg",
                         price = 21600,
                         ifFavourite = false,
                         available = true,
                         Category = Categories["Электрогитары_6"]
                     },
                     new Guitar
                     {
                         name = "FENDER SQUIER BULLET",
                         shortDesc = "электрогитара, HSS, фикс. бридж, цвет черный",
                         longDesc = "FENDER SQUIER BULLET STRAT HT HSS BLK – бюджетная модель от знаменитого американского гитарного бренда, простая, практичная и удобная гитара, разработанная для начинающих гитаристов и обучающихся игре на инструменте. Электрогитара обладает всеми характерными чертами, которые сделали Стратокастер одной из самых популярных и любимых моделей в мире. Корпус классической узнаваемой формы окрашен в стильный черный цвет, кленовый гриф имеет удобный профиль «С», на нем будет комфортно играть, если у вас рука небольшого размера. Особенность этой версии Bullet Strat – конфигурация звукоснимателей HSS с пятипозиционным переключателем. Фиксированный бридж обеспечивает стабильность строя. Это отличный выбор для Вашей первой электрогитары, в каком бы музыкальном стиле Вы ни хотели начать играть.",
                         img = "/img/fender_squier_bullet.jpg",
                         price = 13600,
                         ifFavourite = true,
                         available = true,
                         Category = Categories["Электрогитары_6"]
                     },
                     new Guitar
                     {
                         name = "EPIPHONE LES PAUL",
                         shortDesc = "Электрогитара, цвет черный, фурнитура хром",
                         longDesc = "Электрогитара EPIPHONE LES PAUL STUDIO LT Ebony дает возможность приобщиться к классическому стилю электрогитар LES PAUL STUDIO. Изначально эти модели были созданы для работы в студии, но постепенно они завоевали популярность у более широкого круга музыкантов. Это хороший, универсальный инструмент для широкого круга самых разных музыкальных задач. Epiphone представляет бюджетный вариант классической электрогитары LES PAUL STUDIO, сохраняя все ее основные достоинства. Гитара оснащена парой звукоснимателей 650R/700T Zebra Coil Ceramic Humbuckers от производителя. Цвет гитары черный (Ebony).",
                         img = "/img/Epiphone_les_paul.jpg",
                         price = 19600,
                         ifFavourite = false,
                         available = true,
                         Category = Categories["Электрогитары_6"]
                     },
                     new Guitar
                     {
                         name = "EPIPHONE SG-SPECIAL",
                         shortDesc = "Электрогитара, формы SG, цвет вишня",
                         longDesc = "Электрогитара EPIPHONE SG-Special VE Cherry дает возможность приобщиться к классическому стилю электрогитар линейки SG. Кроме оригинального стиля, эта гитара имеет более демократичную цену, при этом она имеет полностью идентичный внешний вид и хорошее звучание. Бренд Epiphone представляет бюджетный вариант классической электрогитары SG, сохраняя все ее основные достоинства. На деку гитары установлен комплект звукоснимателей-хамбакеров, это модели 650R и 700T Humbuckers от производителя. Цвет гитары - вишня (Cherry).",
                         img = "/img/EPIPHONE_SG_SPECIAL.jpg",
                         price = 16100,
                         ifFavourite = true,
                         available = true,
                         Category = Categories["Электрогитары_6"]
                     },
                     new Guitar
                     {
                         name = "JACKSON JS22 DKA",
                         shortDesc = "электрогитара, цвет черный, материал корпуса - тополь, накладка грифа - амарант, количество ладов: 24, мензура 25.5', звукосниматели H/H: High-Output Humbucking neck & bridge pickups, регуляторы: 1 громкость, 1 тон, 3-х позиционный переключатель, бридж тремоло 2-Point Fulcrum Tremolo, цвет фурнитуры: черный",
                         longDesc = "JACKSON JS22 DKA – шестиструнная электрогитара, модель из бюджетной линейки JS Series. Dinky™ JS22 – это классический звук, узнаваемый дизайн и удобство при игре, характерные для инструментов Jackson, доступные по доступной цене. Гитара заключена в стильный корпус эргономичной формы Dinky™ из тополя. Гриф – из цельного куска клёна, привинченный, с графитовым усилением, обеспечивающим максимальную стабильность. Отделка грифа – матовая. Накладка – из амаранта, переменного радиуса 12-16 дюймов. На грифе 24 лада джамбо, инкрустированных перламутровыми «акульими плавниками». Голова грифа - Jackson® Pointed (6 в ряд). Мощный и при этом чистый звук инструмента формируют два хамбакера собственного производства Jackson® с высоким выходным уровнем.",
                         img = "/img/JACKSON_JS22_DK.jpg",
                         price = 25600,
                         ifFavourite = true,
                         available = true,
                         Category = Categories["Электрогитары_6"]
                     },
                     new Guitar
                     {
                         name = "JACKSON JS22-7 DKA",
                         shortDesc = "7-струнная электрогитара, цвет черный, материал корпуса - тополь, накладка грифа - амарант, количество ладов: 24, мензура 26.5, звукосниматели H / H: High - Output 7 - String Humbucking neck & bridge pickups, регуляторы: 1 громкость, 1 тон, 3 - х позиционный переключатель, бридж фиксированный Jackson® HT7 String - Through - Body Hardtail, цвет фурнитуры: черный",
                         longDesc = "JACKSON JS22-7 DKA AH FB - HT STN BLK - семиструнная электрогитара с мензурой 26,5’’, модель из бюджетной линейки JS Series. Dinky™ JS22-7 – это мощный звук с усиленными низкими частотами, узнаваемый дизайн и удобство при игре. Гитара заключена в корпус эргономичной формы Dinky™ из тополя. Гриф – из цельного куска клёна, привинченный, с графитовым усилением, обеспечивающим максимальную стабильность. Отделка грифа – матовая. Накладка – из амаранта, переменного радиуса 12-16 дюймов. На грифе 24 лада джамбо, инкрустированных маленькими «акульими плавниками» - Piranha Tooth. Голова грифа - Jackson® 3x4 AT-1. Мощный и при этом чистый звук инструмента формируют два хамбакера собственного производства Jackson® с высоким выходным уровнем, специально разработанными для семиструнных гитар. Переключатель – 3-позиционный, регуляторы – громкость и тембр. Фиксированный бридж Jackson® HT7 (струны сквозь корпус) обеспечивает стабильность строя. Гитара представлена в стильном черном матовом цвете с черной фурнитурой и головой грифа в цвет корпуса.",
                         img = "/img/JACKSON_JS22_7_DKA.jpg",
                         price = 28900,
                         ifFavourite = true,
                         available = true,
                         Category = Categories["Электрогитары_7"]
                     },
                      new Guitar
                      {
                          name = "DEAN RC7X WRAITH",
                          shortDesc = "7-струнная электрогитара типа superstrat,24 лада,25 1/2 ,HH,1V, графика wraith, с кейсом",
                          longDesc = "Dean RC7X WRAITH - 7 струнная электрогитара из именной серии Rusty Cooley Signature Series (Rusty Cooley - один из самых техничных и быстрых гитаристов в США). Корпус и топ этого инструмента изготовлены из ольхи. Гриф - кленовый с накладкой из черного дерева, крепится к корпусу на болтах. На гитаре установлены звукосниматели EMG707, колки гровер и бридж Floyd Rose. На инструмент нанесена графика Wraith (призрак). Инструмент поставляется в кейсе.",
                          img = "/img/DEAN_RC7X_WRAITH.jpg",
                          price = 94490,
                          ifFavourite = true,
                          available = true,
                          Category = Categories["Электрогитары_7"]
                      },
                      new Guitar
                      {
                          name = "IBANEZ RGD71AL-ANB AXION LABEL RGD 7-STRING",
                          shortDesc = "7-струнная электрогитара, цвет санбёрст, материал корпуса - волнистый клён, ясень, орех, накладка грифа - эбони, количество ладов: 24, мензура 25,5 звукосниматели H / H: DiMarzio® Fusion Edge - 7(H) neck pickup, DiMarzio® Fusion Edge - 7(H) bridge pickup, регуляторы: 1 громкости, трехпозиционный переключатель, бридж фиксированный, цвет фурнитуры: черный.",
                          longDesc = "IBANEZ RGD71AL-ANB AXION LABEL RGD 7-STRING - это семиструнная электрогитара. Гитары этой линейки пользуются популярностью у музыкантов, играющих рок и инструментальную музыку. Электрогитара имеет шикарное звучание, узнаваемый стиль деки и головы грифа. Накладка грифа из черного дерева. Крепление грифа к деке выполнено на винтах. Дека гитары 3-составная - волнистый клён, ясень и орех. Цвет гитары санберст.",
                          img = "/img/IBANEZ_RGD71AL-ANB.jpg",          
                          price = 83200,
                          ifFavourite = true,
                          available = true,
                          Category = Categories["Электрогитары_7"]
                      },
                      new Guitar
                      {
                          name = "YAMAHA F310",
                          shortDesc = "акустическая гитара, верхняя дека ель, нижняя дека и обечайка меранти, гриф нато, накладка на гриф палисандр, хромированные колки, цвет натуральный",
                          longDesc = "F310 воплощает приверженность качеству дизайна и звучания, свойственному всем акустикам Yamaha, и объединяет эти достоинства в единое целое по непревзойденно доступной цене. Прекрасный звук и отличное качество изготовления по демократичной цене - отличительные особенности гитары серии F.Эта гитара способна передавать самые тонкие оттенки настроения, ее можно назвать совершенным инструментом как для начинающих музыкантов, так и для опытных гитаристов. Традиционный дизайн дредноутов в сочетании с громким акустическим звучанием и хорошими игровыми качествами делают этот инструмент идеальным выбором.Юные гитаристы по достоинству оценят комфорт при игре благодаря немного уменьшенной глубине корпуса и средней длине мензуры.",
                          img = "/img/YAMAHA_F310.jpg",
                          price = 9990,
                          ifFavourite = true,
                          available = true,
                          Category = Categories["Акустические гитары"]
                      },
                      new Guitar
                      {
                          name = "FENDER SQUIER SA-150",
                          shortDesc = "акустическая гитара, дредноут, цвет натуральный",
                          longDesc = "Squier SA-150 - полноразмерная акустическая гитара со стальными струнами, которая предлагает насыщенный, «взрослый звук» по достаточно невысокой цене.",
                          img = "/img/FENDER_SQUIER_SA_150.jpg",
                          price = 6700,
                          ifFavourite = true,
                          available = true,
                          Category = Categories["Акустические гитары"]
                      },
                      new Guitar
                      {
                          name = "FENDER CD-60 DREAD V3",
                          shortDesc = "акустическая гитара, цвет черный, задняя дека и обечайка - махагони, верхняя дека - ель, накладка грифа - орех",
                          longDesc = "FENDER CD-60 DREAD V3 DS – идеальный инструмент для начинающих музыкантов. Это настоящий Фендер, при этом цена модели весьма невысока. Если Вы молодой музыкант, лучшая гитара, которую Вы можете выбрать, – это инструмент, звук и удобство которого вдохновят Вас играть больше и больше. Модель 2019 года FENDER CD-60 – именно такая гитара. Впрочем, она также прекрасно подойдет и опытным гитаристам, которым нужен недорогой второй дредноут. Эта акустическая гитара обладает отлично сбалансированным звучанием, а корпус дредноут с верхней декой из ели позволяет добиться высокой громкости.",
                          img = "/img/FENDER_CD_60_DREAD.jpg",
                          price = 13600,
                          ifFavourite = true,
                          available = true,
                          Category = Categories["Акустические гитары"]
                      }
                    );
            }

             content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электрогитары_6", desc = "Электрогитара 6-ти струнная" },
                        new Category { categoryName = "Электрогитары_7", desc = "Электрогитара 7-ти струнная" },
                        new Category { categoryName = "Акустические гитары", desc = "Акустическая гитара" }

                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
