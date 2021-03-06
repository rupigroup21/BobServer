﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BuyOrBye.Models;

namespace BuyOrBye.Controllers
{
    public class UserController : ApiController
    {
        // GET //
        public List<User> Get()
        {
            User newUser = new User();
            return newUser.getUserList();

        }

        //POST//
        public void Post([FromBody]User user)
        {
            user.InsertUser();

        }

        [HttpPost]
        [Route("api/User/Indecision")]
        public void PostIndecision([FromBody]User user)
        {
            user.InsertIndecision();

        }

        //put User And Category
        [HttpPut]
        [Route("api/User/UserAndCategory")]
        public int CountryUp(User user)
        {
            User userAndCategory = new User();
            return userAndCategory.updateUserAndCategory(user);
        }

        //get signIn
        [HttpGet]
        [Route("api/User/signIn/{email}/{password}/")]
        public User Get(string email, string password)
        {

            User signInUser = new User();


            return signInUser.isSignInSuccModel(email, password);


        }

        //get all the users that exist in the list that the user send
        [HttpGet]
        [Route("api/User/phoneNumbersString/{phoneNumber}/")]
        public List<User> Get(string phoneNumber)
        {

            User createNewGroup = new User();

            return createNewGroup.createNewGroupModel(phoneNumber);


        }

        [HttpPut]
        [Route("api/User/{User}/")]
        public int updateUserAccount(User user)
        {
            User userAccount = new User();
            return userAccount.updateUserAccount(user);
        }


        // get user name to present on ome page
        [HttpGet]
        [Route("api/User/UserEmail/{email}/{num}/")]
        public List<User> Get(string Email, bool num)
        {

            User createNewGroup = new User();

            return createNewGroup.giveUserEmailModel(Email);


        }


    }
}