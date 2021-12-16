using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SlugifyNet.Tests
{
    public class SlugifyTests
    {
        [Fact]
        public void replace_whitespaces_with_replacement()
        {
            Assert.Equal("foo-bar-baz", "foo bar baz".GenerateSlug());
            Assert.Equal("foo_bar_baz", "foo bar baz".GenerateSlug(replacement: "_"));
        }

        [Fact]
        public void remove_duplicates_of_the_replacement_character()
        {
            Assert.Equal("foo-bar", "foo , bar".GenerateSlug());
        }

        [Fact]
        public void remove_trailing_space_if_any()
        {
            Assert.Equal("foo-bar-baz", " foo bar baz ".GenerateSlug());
        }

        [Fact]
        public void remove_not_allowed_chars()
        {
            Assert.Equal("foo-bar-baz", "foo, bar baz".GenerateSlug());
            Assert.Equal("foo-bar-baz", "foo- bar baz".GenerateSlug());
            Assert.Equal("foo-bar-baz", "foo] bar baz".GenerateSlug());
            Assert.Equal("foo-bar-baz", "foo  bar--baz".GenerateSlug());
        }

        [Fact]
        public void leave_allowed_chars()
        {
            var allowed = new char[] { '*', '+', '~', '.', '(', ')', '\'', '"', '!', ':', '@' };
            allowed.ToList().ForEach(symbol =>
            {
                var text = "foo " + symbol + " bar baz";
                var actual = text.GenerateSlug();
                var expected = "foo-" + symbol + "-bar-baz";

                Assert.Equal(expected, actual);
            });
        }

        [Fact]
        public void options_replacement()
        {
            Assert.Equal("foo_bar_baz", "foo bar baz".GenerateSlug(replacement: "_"));
        }

        [Fact]
        public void options_replacement_empty_string()
        {
            Assert.Equal("foobarbaz", "foo bar baz".GenerateSlug(replacement: ""));
        }

        [Fact]
        public void options_lower()
        {
            Assert.Equal("Foo-bAr-baZ", "Foo bAr baZ".GenerateSlug(lower: false));
        }

        [Fact]
        public void replace_latin_chars()
        {   
            var characters = new Dictionary<string, string>
            {
                { "À", "A" }, { "Á", "A" }, { "Â", "A" }, { "Ã", "A" }, { "Ä", "A" }, { "Å", "A" }, { "Æ", "AE" },
                { "Ç", "C" }, { "È", "E" }, { "É", "E" }, { "Ê", "E" }, { "Ë", "E" }, { "Ì", "I" }, { "Í", "I" },
                { "Î", "I" }, { "Ï", "I" }, { "Ð", "D" }, { "Ñ", "N" }, { "Ò", "O" }, { "Ó", "O" }, { "Ô", "O" },
                { "Õ", "O" }, { "Ö", "O" }, { "Ő", "O" }, { "Ø", "O" }, { "Ù", "U" }, { "Ú", "U" }, { "Û", "U" },
                { "Ü", "U" }, { "Ű", "U" }, { "Ý", "Y" }, { "Þ", "TH" }, { "ß", "ss" }, { "à", "a" }, { "á", "a" },
                { "â", "a" }, { "ã", "a" }, { "ä", "a" }, { "å", "a" }, { "æ", "ae" }, { "ç", "c" }, { "è", "e" },
                { "é", "e" }, { "ê", "e" }, { "ë", "e" }, { "ì", "i" }, { "í", "i" }, { "î", "i" }, { "ï", "i" },
                { "ð", "d" }, { "ñ", "n" }, { "ò", "o" }, { "ó", "o" }, { "ô", "o" }, { "õ", "o" }, { "ö", "o" },
                { "ő", "o" }, { "ø", "o" }, { "ù", "u" }, { "ú", "u" }, { "û", "u" }, { "ü", "u" }, { "ű", "u" },
                { "ý", "y" }, { "þ", "th" }, { "ÿ", "y" }, { "ẞ", "SS" }
            };

            foreach (var c in characters)
            {
                var text = "foo " + c.Key + " bar baz";
                var actual = text.GenerateSlug(lower: false);
                var expected = "foo-" + c.Value + "-bar-baz";

                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void replaces_leading_and_trailing_replacement_chars()
        {
            Assert.Equal("Come-on-fhqwhgads", "-Come on, fhqwhgads-".GenerateSlug(lower: false));
        }

        [Theory]
        [InlineData("Elon Musk considers move to Mars", "elon-musk-considers-move-to-mars")]
        [InlineData("Fintech startups raised $34B in 2019", "fintech-startups-raised-dollar34b-in-2019")]
        [InlineData("Shopify joins Facebook’s cryptocurrency Libra Association", "shopify-joins-facebook's-cryptocurrency-libra-association")]
        [InlineData("What is a slug and how to optimize it?", "what-is-a-slug-and-how-to-optimize-it")]
        [InlineData("Bitcoin soars past $33,000, its highest ever", "bitcoin-soars-past-dollar33000-its-highest-ever")]
        public void article_title(string input, string expected)
        {
            var actual = input.GenerateSlug();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("mark of ∞", "de", "mark-of-unendlich")]
        [InlineData("mark of ∞", "es", "mark-of-infinito")]
        public void locale_of_infinity_de_es(string input, string locale, string expected)
        {
            var actual = input.GenerateSlug(locale: locale);

            Assert.Equal(expected, actual);
        }
    }
}
