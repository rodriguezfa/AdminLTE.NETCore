

//TODO: Refactor to simplify
$("li[id^='left-sidebar-menu']").on("click", function () {
    var $this = $(this);
    var checkElement = $this.next();
    var parent_li = $this.parent("ul");
    if (!$this.hasClass('active')) {
        //if (parent_li.hasClass('treeview-menu')) { //This limits only to tree items, need to handle no three items.
        //if (true) {  //This should allow all menu options
            //Clear the section to plug in new content.
            $(".content-wrapper").empty();

            var url = $this.attr("controllerInfo");
            $.post(url).done(function (response) {
                $(".content-wrapper").html(response).after(function () {

                    var scripturl = $this.attr("scriptToRun");

                    //Check if a script is defined for the controller
                    if (scripturl) {
                        //Handle multiple scripts.
                        $.getMultiScripts(scripturl.split(',')).done(function () {
                            // all scripts loaded
                            window.console.log('Done loading scripts');
                        });
                    }
                }
                    );

                //Clear any previous menu option
                $("li[id^='left-sidebar-menu']").removeClass('active');

                //Set that the menu option is now active
                $this.addClass("active");
            });
        //}
    };
});


//http://stackoverflow.com/questions/11803215/how-to-include-multiple-js-files-using-jquery-getscript-method
$.getMultiScripts = function (arr, path) {
    var _arr = $.map(arr, function (scr) {
        return $.getScript((path || "") + scr);
    });

    _arr.push($.Deferred(function (deferred) {
        $(deferred.resolve);
    }));

    return $.when.apply($, _arr);
}
