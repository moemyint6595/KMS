const myVariable = {

    //Utilities
    AppBackgroundColor: "--app-bg-color",
    CoreColor: "--core-color",
    SecondaryCoreColor : "--core-second-color",
    TextColor: "--text-color",
    TextCoreColor : "--core-text-color",
    IconColor: "--icon-color",

    //NavMenu
    NavMenuBackground: "--nav-bg-color",
}

window.RootJsFunctions = {

    ChangeTheam: function (theme) {
        try {
            if (typeof this[theme] == "function") {
                this[theme]();
            } else {
                this.ChangeTheam("MainTheme");
            }
        } catch (ex) {
            this.MainTheme();
        }
    },

    setElementStyle: function (propertyName, value) {
        document.documentElement.style.setProperty(propertyName, value);
    },

    MainTheme: function () {

        //Utilities
        this.setElementStyle(myVariable.AppBackgroundColor, "#111214");
        this.setElementStyle(myVariable.CoreColor, "#ED6400");
        this.setElementStyle(myVariable.SecondaryCoreColor, "#000000");
        this.setElementStyle(myVariable.TextColor, "#000000");
        this.setElementStyle(myVariable.TextCoreColor, "#000000");
        this.setElementStyle(myVariable.IconColor, "#000000");

        //NavMenu
        this.setElementStyle(myVariable.IconColor, "#FFFFFF");
    },
}