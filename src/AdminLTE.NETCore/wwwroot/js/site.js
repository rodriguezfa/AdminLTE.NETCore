

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
                    }).fail(function (jqxhr, settings, exception) { //fail(function (error) {
                        // one or more scripts failed to load
                        window.console.log('One or more scripts failed to load');
                    }).always(function () {
                        // always called, both on success and error
                    });
                }
            }
                );

            //Clear any previous menu option
            $("li[id^='left-sidebar-menu']").removeClass('active');

            //If the parent is a treeview
            if (!parent_li.hasClass('treeview-menu')) {
                //window.console.log('need to clear any other treeview active.');
                //$(".treeview.active").removeClass('active');

                //Todo: Collapse any active menu.
                //$(".menu-open").removeClass("menu-open");
                //var treeElement = $(".treeview.active");
                //if (treeElement) {
                //    var animationSpeed = $.AdminLTE.options.animationSpeed;
                //    treeElement.slideUp(animationSpeed, function () {
                //        //checkElement.removeClass('open');
                //        //Fix the layout in case the sidebar stretches over the height of the window
                //        //_this.layout.fix();
                //    });
                //}

                var treeElement = $(".treeview.active"); //Parent treeview
                if (treeElement) {

                    treeElement.removeClass('active');

                    var firstchild = treeElement.children('ul')
                    if (firstchild.lenght !== 0) {
                        var animationSpeed = $.AdminLTE.options.animationSpeed;
                        //Close the menu
                        firstchild.slideUp(animationSpeed, function () {
                            firstchild.removeClass('menu-open');
                            //Fix the layout in case the sidebar stretches over the height of the window
                            //_this.layout.fix();
                        });
                    }                    
                }
            }

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
