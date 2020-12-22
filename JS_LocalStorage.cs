$('#btnSetSession').click(function () {
  //sessionStorage.setItem("Name", "Mico Moreno");
  //var colors = ["red", "blue", "green"];
  //localStorage.setItem("my_colors", JSON.stringify(colors)); //store colors
  var dtl = [];
  var vdtl = {};
  var i;
  for (i = 0; i < 5; i++) {
      vdtl = {}
      vdtl["Name"] = "Mico",
      vdtl["Age"] = "24"
      dtl.push(vdtl);
  }

  console.log(dtl);
  localStorage.setObj("myData", dtl);
});

$('#btnGetSession').click(function () {
   //alert(JSON.parse(localStorage.getItem("my_colors")))
   //alert(localStorage.getObj("myData"));
   $.each(localStorage.getObj("myData"), function (i, val) {
       alert(val.Name);
       alert(val.Age);
   });

   //$('#txtEmail').val(sessionStorage.getItem("Name")),
});


 Storage.prototype.setObj = function (key, obj) {
     return this.setItem(key, JSON.stringify(obj))
 }
 Storage.prototype.getObj = function (key) {
     return JSON.parse(this.getItem(key))
 }
