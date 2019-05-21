var mirror = {
    timer:0,
    timerFrequency:1000,
    weatherFrequency: 3600000,
    connection:null,
    init:function() {
        timer = setInterval(function() {
            mirror.changeTime();
        }, mirror.timerFrequency);
        mirror.displayWeather();

        mirror.connection = new signalR.HubConnectionBuilder().withUrl("/messagingHub").build();

        mirror.connection.on("ReceiveMessage", function (message) {
            console.log("ReceiveMessage");
        });

        mirror.connection.start().then(function () {
            console.log("Started");
        }).catch(function (err) {
            return console.error(err.toString());
        });
        
    },
    changeTime:function(){
        var source = $("#time-template").html();
        var template = Handlebars.compile(source);
        var html = template();
        var context = {
            time:moment().format("hh:mm"),
            datestring:moment().format("dddd Do MMMM YYYY")
        };
        var html = template(context);
        $("#time-display").html(html);
    },
    displayWeather:function() {
        $.ajax({
            url:"/Home/GetWeather",
            data:{
            }, 
            success:function(data){
                var source = $("#weather-template").html();
                var template = Handlebars.compile(source);
                var html = template();
                var context = {
                    weather:data.weather[0].description,
                    icon:data.weather[0].iconclass
                };
                var html = template(context);
                $("#weather").html(html);
            }
        });
    }
};

$(document).ready(function() {
    mirror.init();
});