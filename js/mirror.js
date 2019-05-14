var mirror = {
    timer:0,
    timerFrequency:1000,
    init:function() {
        timer = setInterval(function() {
            mirror.changeTime();
        }, mirror.timerFrequency);
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
    }
};

$(document).ready(function() {
    mirror.init();
});