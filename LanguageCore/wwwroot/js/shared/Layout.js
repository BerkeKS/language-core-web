var Layout = new (function () {
    var Variables = this.Variables = {
        ToggleButton: document.getElementById('toggle-btn'),
        Sidebar: document.getElementById('sidebar')
    };
    var Actions = this.Actions = {
        ToggleSideBar: function () {
            Variables.Sidebar.classList.toggle('close');
            Variables.ToggleButton.classList.toggle('rotate');
            Array.from(Variables.Sidebar.getElementsByClassName('show')).forEach(ul => {
                ul.classList.remove('show');
                ul.previousElementSibling.classList.remove('show');
            })
        },
        ToggleSubMenu: function (button) {
            button.nextElementSibling.classList.toggle('show');
            button.classList.toggle('rotate');
            if (Variables.Sidebar.classList.contains('close')) {
                Variables.Sidebar.classList.toggle('close');
                Variables.ToggleButton.classList.toggle('rotate');
            }
        }
    };
})();
