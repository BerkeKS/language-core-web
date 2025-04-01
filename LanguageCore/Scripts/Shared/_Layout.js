var Layout: {
    Actions: {
        toggleNav = function () {
            var sideNavWidth = document.getElementById("mySidenav").style.width;
            if (sideNavWidth == "0") {
                sideNavWidth = "250px";
            } else {
                sideNavWidth = "0"
            }
        }
    }
}