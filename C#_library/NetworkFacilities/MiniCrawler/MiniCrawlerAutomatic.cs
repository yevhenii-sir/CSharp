using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace LearnCSharpWeb
{
    static class MiniCrawlerAutomatic
    {
        static string FindLink(string htmlstr, ref int startloc)
        {
            int i;
            int start, end;
            string uri = null;

            i = htmlstr.IndexOf("href=\"http", startloc, StringComparison.OrdinalIgnoreCase);

            if (i != -1)
            {
                start = htmlstr.IndexOf('"', i) + 1;
                end = htmlstr.IndexOf('"', start);
                uri = htmlstr.Substring(start, end - start);
                startloc = end;
            }

            return uri;
        }

        static void Main(string[] args) //Не понятно работает ли правильно
        {
            string link;
            int tabCount = 0, currentLocation;

            Stack<(string link, string pageData, int curloc)> pagesStack = new ();
            Dictionary<string, int?> links = new Dictionary<string, int?>();

            Console.Write("Введите URL: ");
            string uriStr = Console.ReadLine();

            try
            {
                do
                {
                    Console.WriteLine("Переход по ссылке " + uriStr);
                    WebClient user = new WebClient();
                    string pageData = user.DownloadString(uriStr);

                    uriStr = null;
                    currentLocation = 0;
                    
                    do
                    {
                        link = FindLink(pageData, ref currentLocation);
                        pagesStack.Push((link, pageData, currentLocation));

                        if (link != null && !links.ContainsKey(link))
                        {
                            links.Add(link, null);
                            Console.WriteLine(new String('\t', tabCount) + "Переход по ссылке: " + link);
                            uriStr = link;
                        }
                        else
                        {
                            Console.Write("Больше ссылок не найдено.");
                            if (pagesStack.Count > 0)
                            {
                                (link, pageData, currentLocation) = pagesStack.Pop();
                                Console.WriteLine(" Преход назад и поиск дальше на сайте - " + link);
                                tabCount = 0;
                            }
                            else break;
                        }
                        tabCount++;
                        Thread.Sleep(700);
                    } while (link?.Length > 0);
                } while (uriStr != null);
            }
            catch (WebException exc)
            {
                Console.WriteLine("Сетевая ошибка: " + exc.Message +
                                  "\nКод состояния: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                Console.WriteLine("Протокольная ошибка: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                Console.WriteLine("Ошибка формата URI: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                Console.WriteLine("Неизвестный протокол: " + exc.Message);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода вывода: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                Console.WriteLine("Исключение в связи с нарушением безопасности: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine("Недопустимая операция: " + exc.Message);
            }
        }
    }
}


/*

Введите URL: https://github.com/
Переход по ссылке https://github.com/
Переход по ссылке: https://github.githubassets.com
        Переход по ссылке: https://avatars.githubusercontent.com
                Переход по ссылке: https://github-cloud.s3.amazonaws.com
                        Переход по ссылке: https://user-images.githubusercontent.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://avatars.githubusercontent.com
        Переход по ссылке: https://github.githubassets.com/assets/frameworks-f8b9580b3a0820d152c1d3c6f3ebeaa3.css
                Переход по ссылке: https://github.githubassets.com/assets/behaviors-df71d07850bceb318d296c405b2b4901.css
                        Переход по ссылке: https://github.githubassets.com/assets/github-89fd81159f5eab874be473399d963479.css
                                Переход по ссылке: https://github.githubassets.com/assets/site-752cdbda18aad7a7c33bb68cc14d1442.css
                                        Переход по ссылке: https://github.githubassets.com/assets/home-9bbd3b821f58901bff5acc949a6449fd.css
                                                Переход по ссылке: https://github.com/fluidicon.png
                                                        Переход по ссылке: https://github.githubassets.com/
                                                                Переход по ссылке: https://github.githubassets.com/static/fonts/alliance/Alliance-No-1-ExtraBold.woff2
                                                                        Переход по ссылке: https://github.githubassets.com/static/fonts/alliance/Alliance-No-1-Regular.woff2
                                                                                Переход по ссылке: https://github.com/
                                                                                        Переход по ссылке: https://github.githubassets.com/pinned-octocat.svg
                                                                                                Переход по ссылке: https://github.githubassets.com/favicons/favicon.png
                                                                                                        Переход по ссылке: https://github.githubassets.com/favicons/favicon.svg
                                                                                                                Переход по ссылке: https://docs.github.com/articles/supported-browsers
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/
        Переход по ссылке: https://lab.github.com/
                Переход по ссылке: https://opensource.guide
                        Переход по ссылке: https://github.com/readme
                                Переход по ссылке: https://github.com/events
                                        Переход по ссылке: https://github.community
                                                Переход по ссылке: https://education.github.com
                                                        Переход по ссылке: https://stars.github.com
                                                                Переход по ссылке: https://enterprise.github.com/contact
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://education.github.com
        Переход по ссылке: https://enterprise.github.com/contact?ref_page=/&ref_cta=Contact%20Sales&ref_loc=billboard%20launchpad
                Переход по ссылке: https://www.npmjs.com
                        Переход по ссылке: https://apps.apple.com/app/github/id1477376905?ls=1
                                Переход по ссылке: https://play.google.com/store/apps/details?id=com.github.android
                                        Переход по ссылке: https://desktop.github.com/
                                                Переход по ссылке: https://cli.github.com/
                                                        Переход по ссылке: https://docs.github.com/github/managing-security-vulnerabilities/configuring-dependabot-security-updates
                                                                Переход по ссылке: https://docs.github.com/discussions
                                                                        Переход по ссылке: https://enterprise.github.com/contact?ref_page=/&ref_cta=Contact%20Sales&ref_loc=footer%20launchpad
                                                                                Переход по ссылке: https://resources.github.com
                                                                                        Переход по ссылке: https://github.com/github/roadmap
                                                                                                Переход по ссылке: https://docs.github.com
                                                                                                        Переход по ссылке: https://partner.github.com/
                                                                                                                Переход по ссылке: https://atom.io
                                                                                                                        Переход по ссылке: https://www.electronjs.org
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://desktop.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.community
        Переход по ссылке: https://services.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://lab.github.com/
        Переход по ссылке: https://www.githubstatus.com/
                Переход по ссылке: https://support.github.com
                        Переход по ссылке: https://github.com/about
                                Переход по ссылке: https://github.blog
                                        Переход по ссылке: https://socialimpact.github.com/
                                                Переход по ссылке: https://shop.github.com
                                                        Переход по ссылке: https://twitter.com/github
                                                                Переход по ссылке: https://www.facebook.com/GitHub
                                                                        Переход по ссылке: https://www.youtube.com/github
                                                                                Переход по ссылке: https://www.linkedin.com/company/github
                                                                                        Переход по ссылке: https://github.com/github
                                                                                                Переход по ссылке: https://docs.github.com/en/github/site-policy/github-terms-of-service
                                                                                                        Переход по ссылке: https://docs.github.com/en/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - 
Переход по ссылке https://docs.github.com/en/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/en/github/site-policy/github-privacy-statement
        Переход по ссылке: https://docs.github.com/cn/github/site-policy/github-privacy-statement
                Переход по ссылке: https://docs.github.com/ja/github/site-policy/github-privacy-statement
                        Переход по ссылке: https://docs.github.com/es/github/site-policy/github-privacy-statement
                                Переход по ссылке: https://docs.github.com/pt/github/site-policy/github-privacy-statement
                                        Переход по ссылке: https://docs.github.com/de/github/site-policy/github-privacy-statement
                                                Переход по ссылке: https://cli.github.com/manual
                                                        Переход по ссылке: https://atom.io/docs
                                                                Переход по ссылке: https://electronjs.org/docs
                                                                        Переход по ссылке: https://codeql.github.com/docs
                                                                                Переход по ссылке: https://gdpr-info.eu/art-9-gdpr/
                                                                                        Переход по ссылке: https://creativecommons.org/publicdomain/zero/1.0/
                                                                                                Переход по ссылке: https://github.com/marketplace
                                                                                                        Переход по ссылке: https://github.com/sponsors
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/marketplace
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/sponsors
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://gdpr-info.eu/art-9-gdpr/
        Переход по ссылке: https://github.com/settings/admin
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/admin
        Переход по ссылке: https://support.github.com/contact/privacy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://gdpr-info.eu/art-9-gdpr/
        Переход по ссылке: https://github.com/settings/emails
                Переход по ссылке: https://github.com/settings/profile
                        Переход по ссылке: https://support.github.com/contact?tags=docs-policy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact?tags=docs-policy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact?tags=docs-policy
        Переход по ссылке: https://developer.github.com/changes/2018-05-24-user-migration-api/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/admin
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact?tags=docs-policy
        Переход по ссылке: https://github.com/ghost
                Переход по ссылке: https://www.eff.org/issues/do-not-track
                        Переход по ссылке: https://www.w3.org/TR/tracking-dnt/
                                Переход по ссылке: https://privacybadger.org/
                                        Переход по ссылке: https://github.com/security
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/emails
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/emails
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/emails
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact/privacy
        Переход по ссылке: https://github.com/github/site-policy/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://creativecommons.org/publicdomain/zero/1.0/
        Переход по ссылке: https://github.com/github/site-policy#license
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact/privacy
        Переход по ссылке: https://github.com/github/docs/edit/main/content/github/site-policy/github-privacy-statement.md
                Переход по ссылке: https://github.com/github/docs/blob/main/CONTRIBUTING.md
                        Переход по ссылке: https://github.community/
                                Переход по ссылке: https://support.github.com/contact
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/security
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.githubstatus.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com
        Переход по ссылке: https://github.com/pricing
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://services.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/about
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - 
Переход по ссылке https://github.com/pricing
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://avatars.githubusercontent.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github-cloud.s3.amazonaws.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://user-images.githubusercontent.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://avatars.githubusercontent.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/assets/frameworks-f8b9580b3a0820d152c1d3c6f3ebeaa3.css
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/assets/behaviors-df71d07850bceb318d296c405b2b4901.css
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/assets/site-752cdbda18aad7a7c33bb68cc14d1442.css
        Переход по ссылке: https://github.githubassets.com/assets/pricing-0068ac0c3754c6f17a75ecb51854c874.css
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/fluidicon.png
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/static/fonts/alliance/Alliance-No-1-ExtraBold.woff2
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/static/fonts/alliance/Alliance-No-1-Regular.woff2
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/pinned-octocat.svg
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/favicons/favicon.png
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/favicons/favicon.svg
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://lab.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://opensource.guide
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/readme
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/events
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.community
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://education.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://stars.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://enterprise.github.com/contact
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://education.github.com
        Переход по ссылке: https://enterprise.github.com/contact?ref_page=/enterprise&ref_cta=CustomPriceCalculator&ref_loc=hero
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://enterprise.github.com/contact?ref_page=/enterprise&ref_cta=CustomPriceCalculator&ref_loc=hero
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://enterprise.github.com/contact?ref_page=/enterprise&ref_cta=CustomPriceCalculator&ref_loc=hero
        Переход по ссылке: https://enterprise.github.com/contact?ref_page=/pricing&ref_cta=Contact%20Sales&ref_loc=cards
                Переход по ссылке: https://github.com/customer-stories/trustpilot
                        Переход по ссылке: https://github.com/customer-stories/netdata
                                Переход по ссылке: https://github.com/customer-stories/american-airlines
                                        Переход по ссылке: https://github.com/customer-stories/sap
                                                Переход по ссылке: https://github.com/customer-stories/spotify
                                                        Переход по ссылке: https://github.com/customer-stories/stripe
                                                                Переход по ссылке: https://github.com/customer-stories/ford
                                                                        Переход по ссылке: https://github.com/customer-stories/nubank
                                                                                Переход по ссылке: https://enterprise.github.com/contact?ref_page=/pricing&ref_cta=Contact%20Sales&ref_loc=pricing%20comparison
                                                                                        Переход по ссылке: https://github.com/team
                                                                                                Переход по ссылке: https://education.github.com/benefits/offers
                                                                                                        Переход по ссылке: https://github.com/nonprofit
                                                                                                                Переход по ссылке: https://docs.github.com/en/github/getting-started-with-github/types-of-github-accounts
                                                                                                                        Переход по ссылке: https://docs.github.com/en/github/getting-started-with-github/githubs-products#github-enterprise
                                                                                                                                Переход по ссылке: https://docs.github.com/en/github/setting-up-and-managing-billing-and-payments-on-github/how-does-upgrading-or-downgrading-affect-the-billing-process
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://resources.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/github/roadmap
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://partner.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://atom.io
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.electronjs.org
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://desktop.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.community
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://services.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://lab.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.githubstatus.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/about
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.blog
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://socialimpact.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://shop.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://twitter.com/github
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.facebook.com/GitHub
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.youtube.com/github
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.linkedin.com/company/github
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/github
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/en/github/site-policy/github-terms-of-service
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/en/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - 
Переход по ссылке https://docs.github.com/en/github/setting-up-and-managing-billing-and-payments-on-github/how-does-upgrading-or-downgrading-affect-the-billing-process
        Переход по ссылке: https://docs.github.com/en/billing/managing-billing-for-your-github-account/how-does-upgrading-or-downgrading-affect-the-billing-process
                Переход по ссылке: https://docs.github.com/cn/billing/managing-billing-for-your-github-account/how-does-upgrading-or-downgrading-affect-the-billing-process
                        Переход по ссылке: https://docs.github.com/ja/billing/managing-billing-for-your-github-account/how-does-upgrading-or-downgrading-affect-the-billing-process
                                Переход по ссылке: https://docs.github.com/es/billing/managing-billing-for-your-github-account/how-does-upgrading-or-downgrading-affect-the-billing-process
                                        Переход по ссылке: https://docs.github.com/pt/billing/managing-billing-for-your-github-account/how-does-upgrading-or-downgrading-affect-the-billing-process
                                                Переход по ссылке: https://docs.github.com/de/billing/managing-billing-for-your-github-account/how-does-upgrading-or-downgrading-affect-the-billing-process
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://cli.github.com/manual
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://atom.io/docs
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://electronjs.org/docs
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://codeql.github.com/docs
        Переход по ссылке: https://github.com/github/docs/edit/main/content/billing/managing-billing-for-your-github-account/how-does-upgrading-or-downgrading-affect-the-billing-process.md
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/github/docs/blob/main/CONTRIBUTING.md
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.community/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/security
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.githubstatus.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/pricing
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://services.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/about
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - 
Переход по ссылке https://github.com/github/docs/edit/main/content/billing/managing-billing-for-your-github-account/how-does-upgrading-or-downgrading-affect-the-billing-process.md
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://avatars.githubusercontent.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github-cloud.s3.amazonaws.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://user-images.githubusercontent.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://avatars.githubusercontent.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/assets/frameworks-f8b9580b3a0820d152c1d3c6f3ebeaa3.css
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/assets/behaviors-df71d07850bceb318d296c405b2b4901.css
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/assets/github-89fd81159f5eab874be473399d963479.css
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/fluidicon.png
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/assets/github-89fd81159f5eab874be473399d963479.css
        Переход по ссылке: https://github.com/login
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/pinned-octocat.svg
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/favicons/favicon.png
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.githubassets.com/favicons/favicon.svg
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/articles/supported-browsers
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/
        Переход по ссылке: https://docs.github.com/articles/github-security/
                Переход по ссылке: https://github.com/contact
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - 
Переход по ссылке https://github.com/contact
        Переход по ссылке: https://support-assets.github.com/assets/favicon-3dcd2c977a91b2e3f396b300c5ff0d572295ca632ddb7ba1adcacc1ea68dd5c0.ico
                Переход по ссылке: https://support-assets.github.com/assets/frameworks-0e27fd99365d0ace3ec27ff17e57c03ac73c04130d2244cf1ef0bc136c3f56a1.css
                        Переход по ссылке: https://support-assets.github.com/assets/main-1e37e5dda41d886c173ba1b64b9e8c7c9035294725f228dfae4f2e128cb7013f.css
                                Переход по ссылке: https://support-assets.github.com/assets/noscript-9e2efea8c1bdfc52fe9bc0f62369e07c99ac8305f659aeedd7054fa8fda5925c.css
                                        Переход по ссылке: https://docs.github.com/github/site-policy/submitting-content-removal-requests
                                                Переход по ссылке: https://docs.github.com/github/building-a-strong-community/reporting-abuse-or-spam
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.community
        Переход по ссылке: https://docs.github.com/articles/github-terms-of-service
                Переход по ссылке: https://docs.github.com/articles/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - 
Переход по ссылке https://docs.github.com/articles/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/en/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/cn/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/ja/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/es/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/pt/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://docs.github.com/de/github/site-policy/github-privacy-statement
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://cli.github.com/manual
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://atom.io/docs
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://electronjs.org/docs
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://codeql.github.com/docs
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://gdpr-info.eu/art-9-gdpr/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://creativecommons.org/publicdomain/zero/1.0/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/marketplace
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/sponsors
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/marketplace
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/sponsors
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://gdpr-info.eu/art-9-gdpr/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/admin
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/admin
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact/privacy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://gdpr-info.eu/art-9-gdpr/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/emails
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/profile
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact?tags=docs-policy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact?tags=docs-policy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact?tags=docs-policy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://developer.github.com/changes/2018-05-24-user-migration-api/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/admin
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact?tags=docs-policy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/ghost
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.eff.org/issues/do-not-track
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.w3.org/TR/tracking-dnt/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://privacybadger.org/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/security
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/emails
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/emails
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/settings/emails
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact/privacy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/github/site-policy/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://creativecommons.org/publicdomain/zero/1.0/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/github/site-policy#license
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact/privacy
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/github/docs/edit/main/content/github/site-policy/github-privacy-statement.md
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/github/docs/blob/main/CONTRIBUTING.md
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.community/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com/contact
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/security
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://www.githubstatus.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://support.github.com
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/pricing
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://services.github.com/
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - https://github.com/about
Больше ссылок не найдено. Преход назад и поиск дальше на сайте - 

*/
