const showProduct = async () => {
    let productsList = await getProducts();
    for (let i = 0; i < productsList.length; i++) {
        drowProduct(productsList[i])
    }
}


const getProducts = async () => {
     let url = `/api/Products`;
    let categories = []
    let categoriesElements=document.getElementsByClassName(".opt");
    for (let i = 0; i < categoriesElements.length; i++) {
        if (categoriesElements[i].checked) {
            categories.push(categoriesElements[i].categoryId)
        }
    }
    let desc = document.getElementById("nameSearch").value
    let minPrice = document.getElementById("minPrice").value
    let maxPrice = document.getElementById("maxPrice").value
   

    if (desc!='') {
        url = url + '&desc=${desc}'
    }

    if (minPrice >0) {
        url = url + '&minPrice=${minPrice}'
    }
    if (maxPrice >= minPrice) {
        url = url + '&maxPrice=${maxPrice}'
    }

    for (let i = 0; i < categories.length; i++) {
        url = url + '&categoriesId=${categories[i]}'
    }

    try {
        const responseGet = await fetch(url);

        if (!responseGet.ok) {
            alert("no products")
        }
        else {
            const productsList = await responseGet.json();
            console.log(productsList)
            return productsList;
        }
    }
    catch (error) {
        alert(error)
    }
}



const drowProduct = (product) => {
   let tempProduct = document.getElementById("temp-card");
   let clon = tempProduct.content.cloneNode(true);
    clon.querySelector("img").src = "./Image/" + product.image;
    clon.querySelector("h1").innerText = product.name;
    clon.querySelector(".price").innerText = product.price;
    clon.querySelector(".description").innerText = product.description;
    clon.querySelector("button").addEventListener('click', () => { addToShoppingBag(product) });
    console.log(clon)

    document.getElementById("PoductList").appendChild(clon);


}

const addToShoppingBag = (product) => {

}

const showCategories = async () => {
    let categoriesList = await getCategories();
    for (let i = 0; i < categoriesList.length; i++) {
        drowCategory(categoriesList[i])
    }
   
}

const getCategories = async() => {
    try {
        const responseGet = await fetch(`api/Categories`);
        if (!responseGet.ok) {
            alert("no categories")
        }
        else {
            const categoriesList = await responseGet.json();
            console.log(categoriesList)
            return categoriesList;
        }
    }
    catch (error) {
        alert(error)
    }
}

const drowCategory = (category) => {
    let tempCategory = document.getElementById("temp-category");
    let clon = tempCategory.content.cloneNode(true);
    clon.querySelector(".opt").id = category.categoryId;
    clon.querySelector("label").for = category.categoryId;
    clon.querySelector(".OptionName").innerText = category.name;
    console.log(clon);
    document.getElementById("categoryList").appendChild(clon);
}

const showAll = () => {
    showCategories();
    showProduct();
}

