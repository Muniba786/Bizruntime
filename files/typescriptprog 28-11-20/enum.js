var AppStatus;
(function (AppStatus) {
    AppStatus["ACTIVE"] = "Yes";
    AppStatus[AppStatus["INACTIVE"] = 1] = "INACTIVE";
    AppStatus[AppStatus["ONHOLD"] = 2] = "ONHOLD";
    AppStatus["ONSTOP"] = "STOP";
})(AppStatus || (AppStatus = {}));
console.log(AppStatus.ACTIVE);
console.log(AppStatus.ONHOLD);
