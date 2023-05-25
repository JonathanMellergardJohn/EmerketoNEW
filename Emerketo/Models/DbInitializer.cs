using Emerketo.Areas.Identity.Data;
using System.IO.Pipelines;

namespace Emerketo_webapp.Models
{
    // This class is ONLY for seeding an empty database!
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            EmerketoDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<EmerketoDbContext>();           

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Name = "Awesome Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 1,
                        Rating = 4.3M,
                        Price = 35.00M,
                        IsPopular = false,
                        IsNew = false,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/1.jpg"
                    },
                    new Product
                    {
                        Name = "Aquatic Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 25,
                        Rating = 3.5M,
                        Price = 27.00M,
                        IsPopular = false,
                        IsNew = false,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/2.jpg"
                    },
                    new Product
                    {
                        Name = "Aroma Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 12,
                        Rating = 4.1M,
                        Price = 45.00M,
                        IsPopular = false,
                        IsNew = false,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/3.jpg"
                    },
                    new Product
                    {
                        Name = "Aquatic Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 3,
                        Rating = 2.4M,
                        Price = 17.00M,
                        IsPopular = false,
                        IsNew = false,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/4.jpg"
                    },
                    new Product
                    {
                        Name = "Algea Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = false,
                        IsNew = false,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/5.jpg"
                    },

                    new Product
                    {
                        Name = "Baccu Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = true,
                        IsNew = false,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/6.jpg"
                    },
                    new Product
                    {
                        Name = "Baccu Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = false,
                        IsNew = true,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/7.jpg"
                    },
                    new Product
                    {
                        Name = "Blossoming Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 12,
                        Rating = 4.1M,
                        Price = 45.00M,
                        IsPopular = false,
                        IsNew = false,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/8.jpg"
                    },
                    new Product
                    {
                        Name = "Beautiful Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 3,
                        Rating = 2.4M,
                        Price = 17.00M,
                        IsPopular = true,
                        IsNew = false,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/9.jpg"
                    },
                    new Product
                    {
                        Name = "Bright Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = false,
                        IsNew = true,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/10.jpg"
                    },
                    new Product
                    {
                        Name = "Crooked Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 1,
                        Rating = 4.3M,
                        Price = 35.00M,
                        IsPopular = true,
                        IsNew = true,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/11.jpg"
                    },
                    new Product
                    {
                        Name = "Cavernous Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 25,
                        Rating = 3.5M,
                        Price = 27.00M,
                        IsPopular = true,
                        IsNew = false,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/12.jpg"
                    },
                    new Product
                    {
                        Name = "Cuddly Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 12,
                        Rating = 4.1M,
                        Price = 45.00M,
                        IsPopular = false,
                        IsNew = true,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/13.jpg"
                    },
                    new Product
                    {
                        Name = "Cabbage Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 3,
                        Rating = 2.4M,
                        Price = 17.00M,
                        IsPopular = true,
                        IsNew = false,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/14.jpg"
                    },
                    new Product
                    {
                        Name = "Darling Flower",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = true,
                        IsNew = true,
                        IsFeatured = false,
                        ImgUrl = "/Images/Products/15.jpg"
                    },

                    new Product
                    {
                        Name = "Dear Flower",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = true,
                        IsNew = true,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/16.jpg"
                    },
                    new Product
                    {
                        Name = "Decadent Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = true,
                        IsNew = true,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/17.jpg"
                    },
                    new Product
                    {
                        Name = "Dryair Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = true,
                        IsNew = true,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/18.jpg"
                    },
                    new Product
                    {
                        Name = "Doggy Flower",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = true,
                        IsNew = true,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/19.jpg"
                    },
                    new Product
                    {
                        Name = "Domesticea Plant",
                        ShortDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                            "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                            "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                        LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                            "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                            "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                            "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                            "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                            "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                            "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                            "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                            "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                            "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                            "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                            "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                            "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                            "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                            "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                            "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                            "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                            "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                        NumOfReviews = 35,
                        Rating = 4.9M,
                        Price = 30.00M,
                        IsPopular = true,
                        IsNew = true,
                        IsFeatured = true,
                        ImgUrl = "/Images/Products/20.jpg"
                    }
                );
            }
            context.SaveChanges();
        }
    }
}
