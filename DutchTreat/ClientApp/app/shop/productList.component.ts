﻿import {Component} from "@angular/core"

@Component({
    selector: "product-list",
    templateUrl: "productList.component.html",
    styles: []
})

export class ProductList {
    public products = [{
        title: "First Product",
        price: 19.99
    }, {
        title: "Second Product",
        price: 9.99
    }, {
        title: "Third Product",
        price: 20.00
    }, {
        title: "Fourth Product",
        price: 14.99
    }];
}