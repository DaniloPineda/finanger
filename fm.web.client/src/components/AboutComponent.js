import { Breadcrumb, BreadcrumbItem, Card, CardBody, CardHeader, Media } from 'reactstrap';
import { Link } from 'react-router-dom';
import { Loading } from './LoadingComponent';
import { baseUrl } from './../shared/baseUrl';
import { FadeTransform, Fade, Stagger } from 'react-animation-components';

function About(props) {

    const RenderLeader = ({details}) =>{
        return(
            <div className="col-12 mt-5">
                <FadeTransform in transformProps={{
                    exitTransform:'scale(0.5) translateY(-50%)'
                }}>
                    <Media tag="li">
                        <Media left middle>
                            <Media object src={baseUrl + details.image} alt={details.name}/>
                        </Media>
                        <Media body className="ml-5">
                            <Media heading>{details.name}</Media>
                            <p>{details.designation}</p>
                            <p>{details.description}</p>
                        </Media>
                    </Media>
                </FadeTransform>
            </div>
        )
    }

    const leadersList = props.leaders.leaders.map((leader) => {
        return (
            <Fade in>
                <RenderLeader details={leader} key={leader.id} />
            </Fade>
        );
    });

    const RenderLeaders = ({leaders}) => {
        if(leaders.isLoading){
            return (
                <div className="container">
                    <div className="row">
                        <Loading />
                    </div>
                </div>
            )
        }
        else if (leaders.errMess){
            return(
                <div className="container">
                    <div className="row">
                        <h4>{leaders.errMess}</h4>
                    </div>
                </div>
            )
        }
        else if(leaders.leaders != null)
        return(
            <div className="col-12">
                <Stagger in >
                    <Media list>
                        {leadersList}
                    </Media>
                </Stagger>
            </div>
        );
    }

    return(
        <div className="container">
            <div className="row">
                <Breadcrumb>
                    <BreadcrumbItem><Link to="/home">Home</Link></BreadcrumbItem>
                    <BreadcrumbItem active>About Us</BreadcrumbItem>
                </Breadcrumb>
                <div className="col-12">
                    <h3>About Us</h3>
                    <hr />
                </div>                
            </div>
            <div className="row row-content">
                <div className="col-12 col-md-6">
                    <h2>Our History</h2>
                    <p>...</p>                    
                </div>
                <div className="col-12 col-md-5">
                    <Card>
                        <CardHeader className="bg-primary text-white">Facts At a Glance</CardHeader>
                        <CardBody>
                            <dl className="row p-1">
                                <dt className="col-6">Started</dt>
                                <dd className="col-6">3 Feb. 2013</dd>
                                <dt className="col-6">Major Stake Holder</dt>
                                <dd className="col-6">HK Fine Foods Inc.</dd>
                                <dt className="col-6">Last Year's Turnover</dt>
                                <dd className="col-6">$1,250,375</dd>
                                <dt className="col-6">Employees</dt>
                                <dd className="col-6">40</dd>
                            </dl>
                        </CardBody>
                    </Card>
                </div>
                <div className="col-12">
                    <Card>
                        <CardBody className="bg-faded">
                            <blockquote className="blockquote">
                                <p className="mb-0">You better cut the pizza in four pieces because
                                    I'm not hungry enough to eat six.</p>
                                <footer className="blockquote-footer">Yogi Berra,
                                <cite title="Source Title">The Wit and Wisdom of Yogi Berra,
                                    P. Pepe, Diversion Books, 2014</cite>
                                </footer>
                            </blockquote>
                        </CardBody>
                    </Card>
                </div>
            </div>
            <div className="row row-content">
                <div className="col-12">
                    <h2>Corporate Leadership</h2>
                </div>
                <RenderLeaders leaders={props.leaders}/>
            </div>
        </div>
    );
}

export default About;    