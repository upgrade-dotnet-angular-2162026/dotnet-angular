"use strict";
//enum demo2
var AppStatus;
(function (AppStatus) {
    AppStatus["ACTIVE"] = "ACT";
    AppStatus["INACTIVE"] = "INACT";
    AppStatus[AppStatus["ONSTOP"] = 0] = "ONSTOP";
    AppStatus["ONHOLD"] = "HLD";
})(AppStatus || (AppStatus = {}));
console.log(AppStatus.ONHOLD);
console.log(AppStatus.ONSTOP);
