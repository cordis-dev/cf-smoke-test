while (!!foo1) {
}

// should not report no-undef and no-unused-vars
// should report no-empty
var a = someFunction();
b = 10;

module.exports = {
    "extends": "eslint:recommended",
    "rules": {
        // enable additional rules
        "indent": ["error", 4],
        "linebreak-style": ["error", "unix"],
        "quotes": ["error", "single"],
        "semi": ["error", "always"],

        // override default options for rules from base configurations
        "comma-dangle": ["error", "always"],
        "no-cond-assign": ["error", "always"],
        "no-await-in-loop": "warn",
        "for-direction": "warn"
    }
}

// should not report no-undef and no-unused-vars
// should report no-empty
var c = someFunction();
d = 20;

while (!!foo2) {
}
