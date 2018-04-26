using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    /* [Route("api/[controller]/[action]")]*/
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {        
        /*[HttpGet]
        public string GetDTO(string a)
        {
            return a;
        }

        [HttpGet]
        public IEnumerable<string> ListDTO(string a, string b){
            return new string[] { a, b };
        }
        

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string a)
        {
            return "Post Value : " + a;
        }

        // PUT api/values/5
        //[HttpPut("{id}")]
        [HttpPut]
        public string Put(string a)
        {
            return "Put Value:"+ a;
        }

        // DELETE api/values/5
        //[HttpDelete("{id}")]
        [HttpDelete]
        public string Delete(string a)
        {
            return "Delete Value:" + a;
        }
        */

        // GET api/values/ListCustom
        [HttpGet]
        public IEnumerable<PostItem> ListCustom()
        {
            PostItem postItem0 = new PostItem(){value="ListCustom 0"};
            PostItem postItem1 = new PostItem(){value="ListCustom 1"};
            return new PostItem[] { postItem0, postItem1 };
        }

        // GET api/values/GetCustom?id2=5
        [HttpGet]
        public PostItem GetCustom(int id2)
        {
            PostItem postItem0 = new PostItem(){value="GetCustom 0"};
            PostItem postItem1 = new PostItem(){value="GetCustom 1"};
            return new PostItem[] { postItem0, postItem1 }[id2];
        }

        // GET api/values/List
        [HttpGet]
        public IEnumerable<PostItem> List()
        {
            PostItem postItem0 = new PostItem(){value="List 0"};
            PostItem postItem1 = new PostItem(){value="List 1"};
            return new PostItem[] { postItem0, postItem1 };
        }

        // GET api/values/Get/5
        [HttpGet("{id}")]
        public PostItem Get(int id)
        {
            PostItem postItem0 = new PostItem(){value="Get 0"};
            PostItem postItem1 = new PostItem(){value="Get 1"};
            return new PostItem[] { postItem0, postItem1 }[id];
        }

        // POST api/values/Post
        [HttpPost]
        public PostItem Post([FromBody]PostItem postItem)
        {
            PostItem postItem0 = new PostItem(){value="Post"}; 
            postItem.value = postItem.value + "-" + postItem0.value;
            return postItem;
        }

        // PUT api/values/Put/5
        [HttpPut("{id}")]
        public PostItem Put(int id, [FromBody]PostItem postItem)
        {
            PostItem postItem0 = new PostItem(){value="Put"}; 
            postItem.value = postItem.value + "-" + postItem0.value;
            return postItem;
        }

        // DELETE api/values/Delete/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            PostItem postItem0 = new PostItem(){value="Delete"}; 
            return "Delete Value : " + id.ToString() + " - " + postItem0.value;
        }
    }
}
