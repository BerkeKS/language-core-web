var Layout = new (function () {
    var Actions = this.Actions = {
        ToggleNav: function () {
            var sideNavWidth = document.getElementById("mySidenav").style.width;
            if (sideNavWidth == "0") {
                sideNavWidth = "250px";
            } else {
                sideNavWidth = "0"
            }
        }
    };
})();