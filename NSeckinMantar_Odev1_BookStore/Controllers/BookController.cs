﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSeckinMantar_Odev1_BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSeckinMantar_Odev1_BookStore.Controllers
{
    [Route("api/v1/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //This list represent our database
        public static List<Book> bookList = new List<Book>()
        {
            new Book(){Id=1,SerialNumber="A2021",BookName="Ornek 1",Author="Yazar 1",PublishDate="../../2021" },
            new Book(){Id=2,SerialNumber="B2021",BookName="Ornek 2",Author="Yazar 2",PublishDate="../../2021" },
            new Book(){Id=3,SerialNumber="C2021",BookName="Ornek 3",Author="Yazar 3",PublishDate="../../2021" },
            new Book(){Id=4,SerialNumber="D2021",BookName="Ornek 4",Author="Yazar 4",PublishDate="../../2021" },
            new Book(){Id=5,SerialNumber="E2021",BookName="Ornek 5",Author="Yazar 5",PublishDate="../../2021" },
            new Book(){Id=6,SerialNumber="F2021",BookName="Ornek 6",Author="Yazar 6",PublishDate="../../2021" },
        };



        //Request URL: https://localhost:44318/api/v1/books
        //You can use The HttpGet request to reach all book list
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(bookList);
        }



        //Request URL: https://localhost:44318/api/v1/books/id?id=6
        //You can use The HttpGet request with id parameter to reach just one book object
        //Id parameter sends via "QueryString"
        [HttpGet("id")]
        public IActionResult GetById([FromQuery] int id)
        {
            var book = bookList.Where(x => x.Id.Equals(id)).FirstOrDefault();
            if (book == null)
            {
                return NotFound("There is no record with sended Id");
            }
            return Ok(book);
        }



        ////Request URL: https://localhost:44318/api/v1/books/1
        /////Id parameter sends via FromRoute
        //[HttpGet("{id}")]
        //public IActionResult GetById([FromRoute] int id)
        //{
        //    var book = bookList.Where(x => x.Id.Equals(id)).FirstOrDefault();
        //    if (book == null)
        //    {
        //        return NotFound("There is no record with sended Id");
        //    }
        //    return Ok(book);
        //}


    }
}
