using Microsoft.AspNetCore.Mvc;
using SharedData.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Server.Data;
using WebApi_Server.Models;


namespace WebApi_Server.Controllers
{

    //REST


    //CRUD

    //Create
    //POST
    // -- 생성 Body(내용물)

    //Read
    //GET

    //Update
    //PUT

    //Delete
    //DELETE

    //ApiConteroller
    //1. 그냥 C# 객체를 반환해도 된다
    //2. null 반환하면 -> 클라에 204 response (No content)
    //3. string -> text/plain
    //4. 나머지 (int , bool)  -> appiilcation/json


    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        ApplicationDBContext context;

        public UsersController(ApplicationDBContext _context)
        {
            context = _context;
        }
        //CREATE
        [HttpPost]
        public UserInfo AddUser([FromBody] UserInfo _info)
        {
            UserInfo findUser = context.users.Where(x => x.userID == _info.userID).FirstOrDefault();

            //아이디 존재 여부 확인
            if (findUser != null)
                return null;

            context.users.Add(_info);
            context.SaveChanges();

            return findUser;
        }
        //READ
        [HttpGet]
        public List<UserInfo> GetUserInfos()
        {
            List<UserInfo> result = context.users.ToList();
            return result;
        }

        [HttpGet("{_id}")]
        public UserInfo GetUserInfo(string _id)
        {
            UserInfo result = context.users
                                .Where(x => x.userID == _id)
                                .FirstOrDefault();

            return result;
        }
        //UPDATE
        [HttpPut]
        public bool UpdateUser([FromBody] UserInfo _user)
        {
            UserInfo findUser = context.users.Where(x => x.userID == _user.userID).FirstOrDefault();

            if (findUser == null)
                return false;


            findUser.userID = _user.userID;
            findUser.userName = _user.userName;
            findUser.password = _user.password;


            return true;
        }

        //DELETE
        [HttpDelete("{_id}")]
        public bool DeleteUser(string _id)
        {
            UserInfo findUser = context.users.Where(x => x.userID == _id).FirstOrDefault();

            if (findUser == null)
                return false;

            context.users.Remove(findUser);
            context.SaveChanges();

            return true;
        }

    }
}
