using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CafeteriaKwai.Data;
//public class IdentidadeContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext {
//    public IdentidadeContext(DbContextOptions<IdentidadeContext> options)
//        : base(options) {
//    }
//}
public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {
    }
    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        builder.Entity<ApplicationUser>(entity => {
            entity.Property(i => i.UserImageFileName).HasDefaultValue("Default_UserImage.png");
        });
    }
}
public class CafeContext : DbContext {
    public CafeContext(DbContextOptions<CafeContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductDetail> ProductDetails { get; set; }

    public DbSet<Country> Countries { get; set; }

    public DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Product>().HasData(
      new Product() {
          Id = 1,
          Name = "Charcuterie",
          ShortDescription = "For indecisive food afficianados.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "charcuterie.png",
          Price = 4,
          Category = "Savory",
      },
      new Product() {
          Id = 2,
          Name = "Waffles",
          ShortDescription = "They need no introduction.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "waffles.png",
          Price = 4,
          Category = "Dessert",
      },
      new Product() {
          Id = 3,
          Name = "Santa Fe Salad",
          ShortDescription = "Our house special - we love it.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "salad-special.png",
          Price = 4,
          Category = "Savory",
      },
      new Product() {
          Id = 4,
          Name = "Caesar Salad",
          ShortDescription = "Classically, delicious fresh.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "salad-house.png",
          Price = 4,
          Category = "Savory",
      },
      new Product() {
          Id = 5,
          Name = "Noodles",
          ShortDescription = "Delicious carbs on the go.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "noodles.png",
          Price = 4,
          Category = "Savory",
      },
      new Product() {
          Id = 6,
          Name = "Red Velvet Cake",
          ShortDescription = "Red Velvet...for those who prefer finer things.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "cake.png",
          Price = 4,
          Category = "Dessert",
      },
      new Product() {
          Id = 7,
          Name = "Cupcake",
          ShortDescription = "Vanilla cupcakes with the perfect level of sweetness.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "cupcake.png",
          Price = 4,
          Category = "Dessert",
      },
      new Product() {
          Id = 8,
          Name = "Muffin",
          ShortDescription = "The perfect way to start a Monday morning.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "muffin.png",
          Price = 3,
          Category = "Dessert",
      },
      new Product() {
          Id = 9,
          Name = "Chocolate Bites",
          ShortDescription = "Rich and sweet chocolate bites for those in need of a special treat.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "chocolate.png",
          Price = 5,
          Category = "Kit",
      },
      new Product() {
          Id = 10,
          Name = "Frosted Pumpkin Bread",
          ShortDescription = "A seasonal delight we offer every autumn.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "pumpkinbread.png",
          Price = 4,
          Category = "Dessert",
      },
      new Product() {
          Id = 11,
          Name = "Granola with Nuts",
          ShortDescription = "It's not flashy, but it sure is healthy.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "granola.png",
          Price = 3,
          Category = "Kit",
      },
      new Product() {
          Id = 12,
          Name = "Chocolate Chip Cookies",
          ShortDescription = "They're made fresh every day, and they taste like it.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "cookies.png",
          Price = 2,
          Category = "Kit",
      },
      new Product() {
          Id = 13,
          Name = "Fresh Bagels",
          ShortDescription = "They're just as round as donuts, but far more healthy!",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "bagel.png",
          Price = 5,
          Category = "Dessert",
      },
      new Product() {
          Id = 14,
          Name = "Dark Brewed Coffee",
          ShortDescription = "A classic, refreshing original.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "ground.png",
          Price = 2,
          Category = "Drink",
      },
      new Product() {
          Id = 15,
          Name = "Latte",
          ShortDescription = "More than just coffee, but still just coffee.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "cappucino.png",
          Price = 3,
          Category = "Drink",
      },
      new Product() {
          Id = 16,
          Name = "Americano",
          ShortDescription = "Still classic, but a little more sophisticated.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "beans.png",
          Price = 3.5M,
          Category = "Drink",
      },
      new Product() {
          Id = 17,
          Name = "Designer Espresso",
          ShortDescription = "Caffine has never looked so stunning.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "design.png",
          Price = 6.5M,
          Category = "Drink",
      },
      new Product() {
          Id = 18,
          Name = "Cappucino",
          ShortDescription = "Rich and foamy comfort coffee.",
          Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
          ImageFileName = "cup.png",
          Price = 4.5M,
          Category = "Drink",
      },
      new Product() {
          Id = 19,
          Name = "Iced Mocha",
          ShortDescription = "Cold, creamy, and rich with chocolate.",
          Description = "Uma deliciosa combinação de café gelado com calda de chocolate e leite cremoso. Perfeita para os dias quentes.",
          ImageFileName = "icedmocha.png",
          Price = 5.5M,
          Category = "Drink",
      },
    new Product() {
        Id = 20,
        Name = "Strawberry Smoothie",
        ShortDescription = "Fresh strawberries blended to perfection.",
        Description = "Smoothie de morango natural com iogurte grego, sem adição de açúcares artificiais. Ideal para qualquer hora do dia.",
        ImageFileName = "smoothie.png",
        Price = 6M,
        Category = "Drink",
    },
    new Product() {
        Id = 21,
        Name = "Mango Green Tea",
        ShortDescription = "A tropical twist to classic green tea.",
        Description = "Chá verde gelado com infusão de manga e leve toque cítrico. Refrescante e saudável.",
        ImageFileName = "mango-tea.png",
        Price = 4M,
        Category = "Drink",
    },

    new Product() {
        Id = 22,
        Name = "Tiramisu Cup",
        ShortDescription = "A mini Italian classic.",
        Description = "Camadas de biscoito champagne embebidas em café, com creme de mascarpone e cacau. Um clássico irresistível.",
        ImageFileName = "tiramisu.png",
        Price = 6.5M,
        Category = "Dessert",
    },
    new Product() {
        Id = 23,
        Name = "Fruit Tart",
        ShortDescription = "Colorful, fresh and creamy.",
        Description = "Tartelete com base crocante, creme de baunilha e frutas frescas da estação.",
        ImageFileName = "fruit-tart.png",
        Price = 5.5M,
        Category = "Dessert",
    },
    new Product() {
        Id = 24,
        Name = "Macarons Box",
        ShortDescription = "Assorted flavors, always elegant.",
        Description = "Caixa com 6 macarons artesanais, nos sabores: pistache, chocolate, framboesa, limão, café e baunilha.",
        ImageFileName = "macarons.png",
        Price = 7M,
        Category = "Dessert",
    },

    new Product() {
        Id = 25,
        Name = "Mini Quiche",
        ShortDescription = "Savory bites filled with love.",
        Description = "Mini quiches de alho-poró, queijo e espinafre. Crocantes por fora, cremosas por dentro.",
        ImageFileName = "quiche.png",
        Price = 3.5M,
        Category = "Savory",
    },
    new Product() {
        Id = 26,
        Name = "Spinach & Cheese Empanadas",
        ShortDescription = "Golden crust and savory filling.",
        Description = "Empanadas artesanais recheadas com espinafre refogado e queijo cremoso.",
        ImageFileName = "empanada.png",
        Price = 4M,
        Category = "Savory",
    },
    new Product() {
        Id = 27,
        Name = "Chicken Pesto Sandwich",
        ShortDescription = "Grilled chicken with fresh pesto.",
        Description = "Sanduíche com frango grelhado, molho pesto e tomate seco no pão rústico.",
        ImageFileName = "pesto-sandwich.png",
        Price = 6M,
        Category = "Savory",
    },

    new Product() {
        Id = 28,
        Name = "Café Lovers Kit",
        ShortDescription = "Everything a coffee lover needs.",
        Description = "Kit com pacote de café moído premium, xícara personalizada e biscoitos amanteigados.",
        ImageFileName = "coffee-kit.png",
        Price = 25M,
        Category = "Kit",
    },
    new Product() {
        Id = 29,
        Name = "Brunch Pack",
        ShortDescription = "Perfect combo for late mornings.",
        Description = "Inclui mini quiche, suco natural, fatia de bolo caseiro e uma fruta fresca. Ideal para levar.",
        ImageFileName = "brunch-pack.png",
        Price = 18M,
        Category = "Kit",
    },
    new Product() {
        Id = 30,
        Name = "Dessert Sampler Box-Egg",
        ShortDescription = "A taste of our sweetest selections.",
        Description = "Uma caixa com mini versões de nossos principais doces: cupcake, brownie, cookie e fatia de bolo.",
        ImageFileName = "dessert-kit.png",
        Price = 20M,
        Category = "Kit",
    },
    new Product() {
        Id = 31,
        Name = "X-Sandwich",
        ShortDescription = "Fresh, cheesy, and packed with flavor.",
        Description = "Sanduíche artesanal com tomate fresco, mussarela de búfala e folhas de manjericão, regado com azeite extra virgem e servido em pão ciabatta.",
        ImageFileName = "sandwich.png",
        Price = 5.5M,
        Category = "Savory",
    }
      );
    }
}
