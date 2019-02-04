using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MaterialHouse.Models
{
    public class Repository
    {
        public async Task<List<Cities>> GetCity()
        {
            List<Cities> city;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Cities";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                city = JsonConvert.DeserializeObject<List<Cities>>(JSON);
            }
            return city;
        }

        public List<Cities> GetCitySync()
        {
            List<Cities> city;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Cities";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                city = JsonConvert.DeserializeObject<List<Cities>>(JSON.Result);


            }
            return city;
        }

        public List<Property> GetPropertyByUserSync(int UserId)
        {
            try
            {
                List<Property> property;
                var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Properties?UserId=" + UserId;
                using (var Client = new System.Net.Http.HttpClient())
                {
                    var JSON = Client.GetStringAsync(URLWebAPI);
                    property = JsonConvert.DeserializeObject<List<Property>>(JSON.Result);


                }

                return property;
            }


            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<List<Property>> GetPropertyByUser(int UserId)
        {
            List<Property> property;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Properties?UserId=" + UserId;
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                property = JsonConvert.DeserializeObject<List<Property>>(JSON);
            }
            return property;
        }
        public async Task<List<NewAsset>> GetNewAsset()
        {
            List<NewAsset> newasset;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/NewAssets";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                newasset = Newtonsoft.Json.JsonConvert.DeserializeObject<List<NewAsset>>(JSON);
            }
            return newasset;
        }
        public void PostNewAsset(NewAsset newasset)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(newasset);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/NewAssets";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }


        public List<Cities> GetCityByIdSync(int stateId)
        {
            List<Cities> city;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Cities?StateId=" + stateId;
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                city = JsonConvert.DeserializeObject<List<Cities>>(JSON.Result);


            }
            return city;
        }

        public async Task<List<Users>> GetUsers()
        {
            List<Users> users;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Users";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Users>>(JSON);
            }
            return users;
        }
        public void PostUsers(Users users)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(users);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Users";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }


        public void PostProperties(Property property)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(property);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Properties";
                    response = Client.PostAsync(URLWebAPI, content).Result;



                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public async Task<List<Property>> GetProperty()
        {
            List<Property> property;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Properties";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                property = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Property>>(JSON);
            }
            return property;
        }

        public List<Property> GetPropertySync()
        {
            List<Property> property;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Properties";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                property = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Property>>(JSON.Result);
            }
            return property;
        }

        public async Task<List<PropertyType>> GetPropertyType()
        {
            List<PropertyType> propertytype;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/PropertyTypes";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                propertytype = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PropertyType>>(JSON);
            }
            return propertytype;
        }

        public List<PropertyType> GetPropertyTypeSync()
        {
            List<PropertyType> propertytype;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/PropertyTypes";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                propertytype = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PropertyType>>(JSON.Result);
            }
            return propertytype;
        }


        public async Task<List<PropertyAsset>> GetPropertyAsset()
        {
            List<PropertyAsset> propertyassets;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/PropertyAssets";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                propertyassets = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PropertyAsset>>(JSON);
            }
            return propertyassets;
        }

        public List<PropertyAsset> GetPropertyAssetSync()
        {
            List<PropertyAsset> propertyassets;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/PropertyAssets";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                propertyassets = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PropertyAsset>>(JSON.Result);
            }
            return propertyassets;
        }


        public async Task<List<Note>> GetNote()
        {
            List<Note> note;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Notes";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                note = JsonConvert.DeserializeObject<List<Note>>(JSON);
            }
            return note;
        }

        public List<Note> GetNoteSync()
        {
            List<Note> note;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Notes";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                note = JsonConvert.DeserializeObject<List<Note>>(JSON.Result);


            }
            return note;
        }


        public void PostNote(Note note)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(note);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Notes";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public async Task<List<Paint>> GetPaint()
        {
            List<Paint> paint;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Paints";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                paint = JsonConvert.DeserializeObject<List<Paint>>(JSON);
            }
            return paint;
        }

        public List<Paint> GetPaintSync()
        {
            List<Paint> paint;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Paints";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                paint = JsonConvert.DeserializeObject<List<Paint>>(JSON.Result);


            }
            return paint;
        }


        public void PostPaint(Paint paint)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(paint);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Paints";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public async Task<List<HVAC>> GetHVAC()
        {
            List<HVAC> hvac;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/HVACs";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                hvac = JsonConvert.DeserializeObject<List<HVAC>>(JSON);
            }
            return hvac;
        }

        public List<HVAC> GetHVACSync()
        {
            List<HVAC> hvac;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/HVACs";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                hvac = JsonConvert.DeserializeObject<List<HVAC>>(JSON.Result);


            }
            return hvac;
        }


        public void PostHVAC(HVAC hvac)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(hvac);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/HVACs";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public async Task<List<Appliances>> GetAppliances()
        {
            List<Appliances> app;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Appliances";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                app = JsonConvert.DeserializeObject<List<Appliances>>(JSON);
            }
            return app;
        }

        public List<Appliances> GetAppliancesSync()
        {
            List<Appliances> app;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Appliances";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                app = JsonConvert.DeserializeObject<List<Appliances>>(JSON.Result);


            }
            return app;
        }


        public void PostAppliances(Appliances appliances)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(appliances);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Appliances";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public async Task<List<Doors>> GetDoors()
        {
            List<Doors> door;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Doors";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                door = JsonConvert.DeserializeObject<List<Doors>>(JSON);
            }
            return door;
        }

        public List<Doors> GetDoorsSync()
        {
            List<Doors> door;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Windows";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                door = JsonConvert.DeserializeObject<List<Doors>>(JSON.Result);


            }
            return door;
        }

        public void PostDoors(Doors doors)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(doors);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Doors";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }



        public async Task<List<Windows>> GetWindows()
        {
            List<Windows> win;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Windows";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                win = JsonConvert.DeserializeObject<List<Windows>>(JSON);
            }
            return win;
        }

        public List<Windows> GetWindowsSync()
        {
            List<Windows> win;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Windows";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                win = JsonConvert.DeserializeObject<List<Windows>>(JSON.Result);


            }
            return win;
        }


        public void PostWindows(Windows win)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(win);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Windows";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public async Task<List<Roof>> GetRoof()
        {
            List<Roof> roof;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Roofs";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                roof = JsonConvert.DeserializeObject<List<Roof>>(JSON);
            }
            return roof;
        }

        public List<Roof> GetRoofSync()
        {
            List<Roof> roof;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Roofs";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                roof = JsonConvert.DeserializeObject<List<Roof>>(JSON.Result);


            }
            return roof;
        }


        public void PostRoof(Roof roof)
        {
            System.Net.Http.HttpResponseMessage response = null;
            using (var Client = new System.Net.Http.HttpClient())
            {

                try
                {

                    var JSON = Newtonsoft.Json.JsonConvert.SerializeObject(roof);
                    var content = new StringContent(JSON, Encoding.UTF8, "text/json");
                    var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Roofs";
                    response = Client.PostAsync(URLWebAPI, content).Result;

                    //Debug.WriteLine(response.StatusCode);

                    //if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    //{
                    //    throw new Exception();
                    //}

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }
        public async Task<List<States>> GetState()
        {
            List<States> state;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/States";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                state = Newtonsoft.Json.JsonConvert.DeserializeObject<List<States>>(JSON);
            }
            return state;
        }
        public List<States> GetStateSync()
        {
            List<States> state;
            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/States";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI);
                state = JsonConvert.DeserializeObject<List<States>>(JSON.Result);


            }
            return state;
        }


        public Users  LogIn(string Password, string Email)
        {
            Users login;

            //try
            //{

            var URLWebAPI = "http://50.73.94.149/wsMaterialHouse/api/Users?paramPassword=" + Password + "&paramEmail=" + Email;
            using (var Client = new System.Net.Http.HttpClient())
                {
                var JSON =  Client.GetStringAsync(URLWebAPI).Result;
                login =  Newtonsoft.Json.JsonConvert.DeserializeObject<Users>(JSON);
              
             //   login = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Users>>(JSON);
                }
            //}
            //catch (Exception ex)
            //{
            //    var a = ex.Message;
            //}
            return login;

        }



    }
}
