using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {
        public List<Features> Features { get; set; }
        public List<Services> Services { get; set; }
        public List<Projects> Projects { get; set; }
        public List<Experts> Experts { get; set; }
        public List<Testimonial> Testimonial { get; set; }
    }
}
