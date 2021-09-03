var inpP = document.getElementById('pass'),
    inpU = document.getElementById('user');
inpP.onfocus = function () {
    this.setAttribute("placeHolder", "");
    document.getElementById('label-pass').style.display = 'block';
};
inpP.onblur = function () {
    this.setAttribute("placeHolder", this.getAttribute('data-place'));
    if (this.value === '') {
        document.getElementById('label-pass').style.display = 'none';
    }
};
inpU.onblur = function () {
    this.setAttribute("placeHolder", this.getAttribute('data-place'));
    if (this.value === '') {
        document.getElementById('label-user').style.display = 'none';
    }
    else {
        document.getElementById('label-user').style.display = 'block';
    }
};
inpU.onfocus = function () {
    this.setAttribute("placeHolder", "");
    document.getElementById('label-user').style.display = 'block';
};