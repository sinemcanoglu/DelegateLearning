# Delegate ve Event Arasındaki Farklar

Bu repository, .NET programlama dilinde kullanılan `delegate` ve `event` yapılarını ve aralarındaki temel farkları açıklar.

## Delegate Nedir?

`Delegate`, başka metodları referans alabilen ve onları temsil eden türden güvenli işaretçilerdir. Metodları parametre olarak geçirmenizi sağlar, bu da callback fonksiyonları yazmayı kolaylaştırır.

## Event Nedir?

`Event`, bir veya daha fazla `delegate`'in özel bir durumu olup, `delegate`'lere dayanır. `Event`lar, bir sınıfın dışından sadece abonelik işlemleri için kullanılabilir, bu da onları daha güvenli hale getirir ve encapsulation prensiplerine uyar.

## Ana Farklar

- **Encapsulation**: `Delegate`'ler her yerden çağrılabilirken, `Event`lar yalnızca tanımlandıkları sınıftan tetiklenebilir.
- **Kullanım Amacı**: `Delegate`'ler genellikle tekil callback fonksiyonları için kullanılırken, `Event`lar genellikle birden fazla subscriber'ın olaylara yanıt vermesi gerektiğinde kullanılır.
