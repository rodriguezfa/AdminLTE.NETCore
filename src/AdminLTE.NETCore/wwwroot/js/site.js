// Write your Javascript code.


//document.getElementById('left-sidebar-menu-internal-user-setup').onclick = function () {
//    //this.innerHTML = "Not a button";
//    alert("Menu clicked!");
//};

//$("[id^='left-sidebar-menu']").onclick = function () {
//    //this.innerHTML = "Not a button";
//    alert("Menu clicked!");
//};

//$("li[id^='left-sidebar-menu']").click(function () {
//    //alert("Handler for .click() called.");
//    if (window.console) {
//        window.console.log("Please specify a source first - boxRefresh()");
//    }
//});

//Select items with left-sidebar-menu
//$("li[id^='left-sidebar-menu']").on( "click", function () {
//    //alert("Handler for .click() called.");
//    var $this = $(this);   
//    var checkElement = $this.next();

//    var parent_li = $this.parent("li");

//    if (parent_li.hasClass('treeview-menu')) {
//        window.console.log("treeview-menu");
//    }

//    if (window.console) {
//        window.console.log("Element Clicked");
//    }
//});

$("li[id^='left-sidebar-menu']").on("click", function () {
    var $this = $(this);
    var checkElement = $this.next();
    var parent_li = $this.parent("ul");
    if (!$this.hasClass('active')) {
        if (parent_li.hasClass('treeview-menu')) {
            //Clear the body (class="content") section
            //$(".content").empty();            
            $(".content-wrapper").empty();
            //TODO: Show some progress bar on the cleared section.            
            //Need to get the controller and parameters for controller from li.
            //window.console.log($this.attr("controllerInfo"))
            var url = $this.attr("controllerInfo"); // "/InternalUsers/Index/";
            //$.post(url, { id: id })
            $.post(url).done(function (response) {
                $(".content-wrapper").html(response).after(function () {
                    var scripturl = $this.attr("scriptToRun");
                    if (scripturl) {
                        $.getScript(scripturl, function (data, textStatus, jqxhr) {
                            console.log(data); // Data returned
                            console.log(textStatus); // Success
                            console.log(jqxhr.status); // 200
                            console.log("Load was performed.");
                        });
                    }
                }
                    );

                //Set that the menu option is now active
                $this.addClass('active');

                //Update the top menu.
                //<section class="content-header">
                //$(".content-header").empty();

                //$(".content-header").html(
                // '<h1>' +
                // $this.attr("title") +
                // '</h1>' +
                // '<small>' +
                //    //TODO: Write anything small for the header here.
                // '</small>'
                 //TODO: Add more to display the initial right hand side info.
                    //);
            });

            //Run any defined script here.
            //var url = "/lib/AdminLTE-2.3.11/dist/js/pages/dashboard.js";
            //$.getScript(url, function (data, textStatus, jqxhr) {
            //    console.log(data); // Data returned
            //    console.log(textStatus); // Success
            //    console.log(jqxhr.status); // 200
            //    console.log("Load was performed.");
            //});

            //$.ajax({
            //    url: url,
            //    async: false,
            //    dataType: "script",
            //    success: success
            //});

            //window.console.log("treeview-menu");

            //function success(queuecounters) {
            //    window.console.log("success!");
            //}

        }
    };
});



//Get buttons with class ajaxbutton.
//This can be placed as a separate .js file.
//$(".ajaxbutton").on("click", function () {
//    var $this = $(this);
//    var checkElement = $this.next();
//    var parent_li = $this.parent("ul");

//    window.console.log("ajaxbutton"); //This is the button from the client.

//    if (!$this.hasClass('active')) {
//        if (parent_li.hasClass('treeview-menu')) {
//            //Clear the body (class="content") section
//            //$(".content").empty();

//            ////TODO: Show some progress bar on the cleared section.

//            ////Do an ajax call to the controller.
//            ////Need to get the controller and parameters for controller from li.
//            ////window.console.log($this.attr("controllerInfo"))
//            //var url = $this.attr("controllerInfo"); // "/InternalUsers/Index/";
//            ////$.post(url, { id: id })
//            //$.post(url).done(function (response) {
//            //    $(".content").html(response);

//            //    //Set that the menu option is now active
//            //    $this.addClass('active');

//            //    //Update the top menu.
//            //    //<section class="content-header">
//            //    $(".content-header").empty();

//            //    $(".content-header").html(
//            //     '<h1>' +
//            //     $this.attr("title") +
//            //     '</h1>' +
//            //     '<small>' +
//            //        //TODO: Write anything small for the header here.
//            //     '</small>'
//            //     //TODO: Add more to display the initial right hand side info.
//            //        );

//            //});

//            window.console.log("treeview-menu");
//        }
//    };
//});


//Want to clear the previous active and set the new one.
//$("li[id^='left-sidebar-menu']").on("click", function () {
//    var $this = $(this);
//    var checkElement = $this.next();
//    var parent_li = $this.parent("ul");
//    if (!$this.hasClass('active')) {
//        if (parent_li.hasClass('treeview-menu')) {

//            //Set that the menu option is now active
//            $this.addClass('active');

//            //Clear the body (class="content") section
//            //$(".content").empty();

//            //TODO: Show some progress bar on the cleared section.

//            //Do an ajax call to the controller.
//            //Need to get the controller and parameters for controller from li.
//            //window.console.log($this.attr("controllerInfo"))
//            //var url = $this.attr("controllerInfo"); // "/InternalUsers/Index/";
//            //$.post(url, { id: id })
//            //$.post(url).done(function (response) {
//            //    $(".content").html(response);

//            //    //Set that the menu option is now active
//            //    $this.addClass('active');

//            //    //Update the top menu.
//            //    //<section class="content-header">
//            //    $(".content-header").empty();

//            //    $(".content-header").html(
//            //     '<h1>' +
//            //     $this.attr("title") +
//            //     '</h1>' +
//            //     '<small>' +
//            //        //TODO: Write anything small for the header here.
//            //     '</small>'
//            //     //TODO: Add more to display the initial right hand side info.
//            //        );
//            //});

//        }
//    };
//});
