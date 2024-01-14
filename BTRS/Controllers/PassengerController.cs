using BTRS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTRS.Controllers
{
    public class PassengerController : Controller
    {

        private MyDBContext _dbContext;

        public PassengerController(MyDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {
            return View();
        }


        public bool checkUsername(string username)
        {
            Passenger p = _dbContext.Passengers.Where(u => u.Username.Equals(username)).FirstOrDefault();
            if (p != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

		public bool checkPhoneNumber(string phone)
		{
			Passenger p = _dbContext.Passengers.Where(u => u.PhoneNumber.Equals(phone)).FirstOrDefault();
			if (p != null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool checkEmail(string email)
		{
			Passenger p = _dbContext.Passengers.Where(u => u.Email.Equals(email)).FirstOrDefault();
			if (p != null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool checkEmpty(Passenger passenger)
        {
            if (String.IsNullOrEmpty(passenger.Email)) return false;
            else if (String.IsNullOrEmpty(passenger.Password)) return false;
            else if (String.IsNullOrEmpty(passenger.Name)) return false;
            else return true;
        }



        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Passenger passenger)
        {
            bool duplicateUsername=checkUsername(passenger.Username);
            bool duplicateEmail=checkEmail(passenger.Email);
            bool duplicatePhone = checkPhoneNumber(passenger.PhoneNumber);


			bool empty = checkEmpty(passenger);

            if (empty)
            {
                if (duplicateUsername&&duplicatePhone&&duplicateEmail)
                {
                    _dbContext.Add(passenger);
                    _dbContext.SaveChanges();
                    TempData["msg"] = "data saved successfully";
                }
                else
                {
                    TempData["msg"] = "please change the username/phone/email";
                    return View();  
                }
            }
            else
            {
                TempData["msg"] = "please enter all the required fields";
                return View();
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(Login userLogin)
        {
            


            if(ModelState.IsValid) {
				string pass = userLogin.password;
				string uName = userLogin.userName;

                Passenger passenger=_dbContext.Passengers.Where(u=>u.Username.Equals(uName)&&u.Password.Equals(pass)).FirstOrDefault();

                if(passenger != null)
                {

                }
                else
                {
                    TempData["msg"] = "the username or password is invalid";
                }
			}
            else
            {

            }

            return View();
        }

    }
}

