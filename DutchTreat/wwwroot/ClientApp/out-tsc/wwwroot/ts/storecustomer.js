var StoreCustomer = /** @class */ (function () {
    function StoreCustomer(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    StoreCustomer.prototype.showName = function () {
        console.log(this.firstName + " " + this.lastName);
    };
    Object.defineProperty(StoreCustomer.prototype, "name", {
        get: function () {
            return this.ourName;
        },
        set: function (val) {
            this.ourName = val;
        },
        enumerable: true,
        configurable: true
    });
    return StoreCustomer;
}());
//# sourceMappingURL=storecustomer.js.map