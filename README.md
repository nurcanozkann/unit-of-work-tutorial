###Unit Of Work Pattern
Generic Repository : Oluşturduğumuz bu sınıf , veritabanında karşılığı olan tüm tablolar için genel bir CRUD işlemlerini yapabilmemizi sağlar. Bu sayede kod okunabilirliğini arttırmışken DRY (Don’t Repeat Yourself) yazılım geliştirme ilkesini de çiğnememiş oluruz.

Unit Of Work : Veritabanı ile ilgili tüm işlemlerin tek kanaldan yapılmasını sağlayan ve yapılan tüm işlemlerin hafızada tutularak toplu halde gerçekleştirilmesini sağlayan bir tasarım desenidir.
