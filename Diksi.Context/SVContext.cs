using Diksi.API.Models;
using Diksi.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diksi.Context
{
    public class SVContext : IContext
    {
        private ICollection<Nakladnaya> nakladnayas;
        private ICollection<Pokupatel> pokupatels;
        private ICollection<Postavshik> postavshiks;
        private ICollection<Tovar> tovars;

        public SVContext()
        {
            nakladnayas = new HashSet<Nakladnaya>();
            pokupatels = new HashSet<Pokupatel>();
            postavshiks = new HashSet<Postavshik>();
            tovars = new HashSet<Tovar>();
            Seed();
        }
        public ICollection<Nakladnaya> Nakladnayas => nakladnayas;

        public ICollection<Pokupatel> Pokupatels => pokupatels;

        public ICollection<Postavshik> Postavshiks => postavshiks;

        public ICollection<Tovar> Tovars => tovars;


        private void Seed()
        {
            /// <summary>
            /// Информация накладной
            /// </summary>
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ООО <ПАО>",
                Description = "Накладная № 124234121376 от «24» Ноября 2023г.\r\nПродавец: ООО Лейс, ИНН 12121213124\r\nАдрес продавца: Тореза 40\r\nПокупатель: ИП Логинов, ИНН 12121213124, КПП 342423\r\nАдрес покупателя: Науки"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "Дикси",
                Description = "Накладная № 12343433234 от «10» Мая 2022г.\\r\\nПродавец: ООО Бакузов, ИНН 1213123323\\r\\nАдрес продавца: Коменданский 40\\r\\nПокупатель: ИП Калашников, ИНН 12343433234, КПП 1133322\\r\\nАдрес покупателя: Чернобыль\""
            });
            /// <summary>
            /// Информация покупателя
            /// </summary>
            Pokupatels.Add(new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = "Павел",
                Number = 799102950,
                Adres = "Купчино, ул. Победы 23",
                Index = 8757874,
                Email = "chekpeck@mail.ru"
            });
            Pokupatels.Add(new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = "Андрей",
                Number = 793202950,
                Adres = "Мурино, ул. Коменданского 78",
                Index = 87433874,
                Email = "pol@mail.ru"
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "ilya@mail.ru",
                Name = "Илья",
                Adres = "Санкт-Петербург, ул. Тореза 47",
                Index = 147318,
                Inn = 1234567812,
                RS = 43434234
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "goloand@mail.ru",
                Name = "Голанд",
                Adres = "Санкт-Петербург, ул. Ленина 28",
                Index = 112334,
                Inn = 1235675,
                RS = 4575674
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Шоколадка AlpenGold",
                Edizmer = "5",
                Value = 79
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Кофе Jacobs",
                Edizmer = "87",
                Value = 590
            });
        }
    }
}
