using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public class InitialiezeService : IInitialiezeService
    {
        public ApplicationDbContext db { get; set; }
        public InitialiezeService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void InitializeDb()
        {
            this.db.Settings.Add(new Setting { Name = "Телефон", Key = "Telephone", Value = "088" });
            this.db.Settings.Add(new Setting { Name = "Адрес", Key = "Address", Value = "ul." });
            this.db.Settings.Add(new Setting { Name = "Гугъл мапс локация", Key = "Location", Value = "google" });
            this.db.Settings.Add(new Setting { Name = "Facebook", Key = "Facebook", Value = "Facebook" });
            this.db.Settings.Add(new Setting { Name = "Twetter", Key = "Twetter", Value = "Twetter" });
            this.db.Settings.Add(new Setting { Name = "Име (начална страница)", Key = "NameJumbotron", Value = "Пейком" });
            this.db.Settings.Add(new Setting { Name = "Описание (начална страница)", Key = "DescriptionJumbotron", Value = "Строим пътища които свързват хора и икономики. Пътя към бъдещето." });
            this.db.Settings.Add(new Setting { Name = "Квадрат 1", Key = "SqareOne", Value = "Проектиране" });
            this.db.Settings.Add(new Setting { Name = "Квадрат 1(линк)", Key = "SqareOneLink", Value = "www.google.com" });
            this.db.Settings.Add(new Setting { Name = "Квадрат 2", Key = "SqareTwo", Value = "Строителство" });
            this.db.Settings.Add(new Setting { Name = "Квадрат 2(линк)", Key = "SqareTwoLink", Value = "www.google.com" });
            this.db.Settings.Add(new Setting { Name = "Квадрат 3", Key = "SqareTree", Value = "Поддръжка" });
            this.db.Settings.Add(new Setting { Name = "Квадрат 3(линк)", Key = "SqareTreeLink", Value = "www.google.com" });
            this.db.Settings.Add(new Setting { Name = "Email", Key = "Email", Value = "fsdds@sfdfs.com" });
            
            
            this.db.Pages.Add(new Page { Title = "За Нас", Content = "<p><strong>&bdquo;Пейком България&ldquo; ЕООД </strong>строителство на нови и рехабилитация на съществуващи пътища, строителство, ремонт и поддържане на водопроводни и канализационни системи, строителство, изграждане, реконструкция и ремонт на мостове, мостови съоръжения; поддържане и зимно поддържане на републиканската &nbsp;пътна мрежа</p>"});
            this.db.Pages.Add(new Page { Title = "За Нас НАЧАЛНА СТРАНИЦА", Content = "<p><strong>&bdquo;Пейком България&ldquo; ЕООД </strong>строителство на нови и рехабилитация на съществуващи пътища, строителство, ремонт и поддържане на водопроводни и канализационни системи, строителство, изграждане, реконструкция и ремонт на мостове, мостови съоръжения; поддържане и зимно поддържане на републиканската &nbsp;пътна мрежа</p>" });
            this.db.Pages.Add(new Page { Title = "Контакти", Content = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d727.0442111224531!2d23.552360829235315!3d43.205779998696194!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40ab18e069d7ffb5%3A0x259d544ff49feb03!2z0YPQuy4g4oCe0JrRgNGK0YHRgtGM0L4g0JHRitC70LPQsNGA0LjRj9GC0LDigJwgMTgsIDMwMDIg0JLRgNCw0YbQsCDQptC10L3RgtGK0YAsINCS0YDQsNGG0LA!5e0!3m2!1sbg!2sbg!4v1605707740289!5m2!1sbg!2sbg" });

            


            this.db.SaveChanges();
        }
    }
}
