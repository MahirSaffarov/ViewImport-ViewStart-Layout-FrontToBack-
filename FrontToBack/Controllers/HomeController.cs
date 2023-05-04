using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Features> features = AllFeatures();
            List<Services> services = AllServices();
            List<Projects> projects = AllProjects();
            List<Experts> experts = AllExperts();
            List<Testimonial> testimonial = AllTestimonial();

            HomeVM model = new()
            {
                Features = features,
                Services = services,
                Projects = projects,
                Experts = experts,
                Testimonial = testimonial
            };

            return View(model);
        }
        private List<Features>  AllFeatures()
        {
            Features f1 = new()
            {
                Id = 1,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-1.png"
            };
            Features f2 = new()
            {
                Id = 2,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-2.png"
            };
            Features f3 = new()
            {
                Id = 3,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-3.png"
            };
            Features f4 = new()
            {
                Id = 4,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-4.png"
            };
            List<Features> features = new List<Features>() { f1, f2, f3, f4 };
            return features;
        }
        private List<Services> AllServices()
        {
            Services s1 = new()
            {
                Id = 1,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-5.png"
            };
            Services s2 = new()
            {
                Id = 2,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-6.png"
            };
            Services s3 = new()
            {
                Id = 3,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-7.png"
            };
            Services s4 = new()
            {
                Id = 4,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-8.png"
            };
            Services s5 = new()
            {
                Id = 5,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-9.png"
            };
            Services s6 = new()
            {
                Id = 6,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "icon-10.png"
            };
            List<Services> services = new List<Services>() { s1, s2, s3, s4,s5,s6 };
            return services;
        }
        private List<Projects> AllProjects()
        {
            Projects p1 = new()
            {
                Id = 1,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "project-1.jpg"
            };
            Projects p2 = new()
            {
                Id = 2,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "project-2.jpg"
            };
            Projects p3 = new()
            {
                Id = 3,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "project-3.jpg"
            };
            Projects p4 = new()
            {
                Id = 4,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "project-4.jpg"
            };
            List<Projects> projects = new List<Projects>() { p1, p2, p3, p4 };
            return projects;
        }
        private List<Experts> AllExperts()
        {
            Experts e1 = new()
            {
                Id = 1,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "team-1.jpg"
            };
            Experts e2 = new()
            {
                Id = 2,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "team-2.jpg"
            };
            Experts e3 = new()
            {
                Id = 3,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "team-3.jpg"
            };
            Experts e4 = new()
            {
                Id = 4,
                Head = "Lorem",
                Text = "Ipsum",
                Image = "team-4.jpg"
            };
            List<Experts> experts = new List<Experts>() { e1, e2, e3, e4 };
            return experts;
        }
        private List<Testimonial> AllTestimonial ()
        {
            Testimonial t1 = new()
            {
                Id = 1,
                About= "Dolor",
                Name = "Lorem",
                Position = "Ipsum",
                Image = "testimonial-1.jpg"
            };
            Testimonial t2 = new()
            {
                Id = 1,
                About = "Dolor",
                Name = "Lorem",
                Position = "Ipsum",
                Image = "testimonial-2.jpg"
            };
            Testimonial t3 = new()
            {
                Id = 1,
                About = "Dolor",
                Name = "Lorem",
                Position = "Ipsum",
                Image = "testimonial-3.jpg"
            };
            Testimonial t4 = new()
            {
                Id = 1,
                About = "Dolor",
                Name = "Lorem",
                Position = "Ipsum",
                Image = "testimonial-4.jpg"
            };
            List<Testimonial> testimonial = new List<Testimonial>() { t1, t2, t3, t4 };
            return testimonial;
        }
    }
}